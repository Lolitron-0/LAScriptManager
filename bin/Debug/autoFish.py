import sys
import time
import numpy as np
import cv2
import winsound
from mss import mss
import keyboard
from pynput import mouse
import win32con
import win32api

HAS_AREA = False

mon = {'left': 160, 'top': 160, 'width': 200, 'height': 200}


def on_click(x, y, button, pressed):
    global HAS_AREA
    if button == mouse.Button.left:
        if pressed:
            mon['left'] = x
            mon['top'] = y
            winsound.PlaySound('frame.wav', winsound.SND_FILENAME)
        else:
            mon['width'] = abs(x - mon['left'])
            mon['height'] = abs(y - mon['top'])
            print(mon)
            winsound.PlaySound('frame.wav', winsound.SND_FILENAME)
            HAS_AREA = True
            listener.stop()


def draw_area():
    global HAS_AREA
    HAS_AREA = False
    winsound.PlaySound('on.wav', winsound.SND_FILENAME)
    listener.start()


if __name__ == "__main__":
    listener = mouse.Listener(on_click=on_click)
    keyboard.add_hotkey('0', draw_area)
    mark = cv2.imread('mark.jpg', cv2.IMREAD_GRAYSCALE)

    hwnd = int(sys.argv[2])
    print(hwnd)
    listener.stop()
    with mss() as sct:
        while True:
            if not HAS_AREA:
                continue

            screenShot = sct.grab(mon)
            cur = cv2.cvtColor(np.array(screenShot), cv2.COLOR_BGR2GRAY)
            res = cv2.matchTemplate(cur, mark, cv2.TM_CCOEFF_NORMED)
            loc = np.where(res >= 0.8)
            if loc[0].any():
                win32api.PostMessage(hwnd, win32con.WM_KEYDOWN, 0x45, 0)
                win32api.PostMessage(hwnd, win32con.WM_KEYUP, 0x45, 0)
                print("yes")
                time.sleep(7)
                win32api.PostMessage(hwnd, win32con.WM_KEYDOWN, 0x45, 0)
                win32api.PostMessage(hwnd, win32con.WM_KEYUP, 0x45, 0)
                time.sleep(3)

    listener.join()
