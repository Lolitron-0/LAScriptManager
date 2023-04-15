import sys
import time
import numpy as np
import cv2
import winsound
from mss import mss
import keyboard
from pynput import mouse
import pyautogui
import win32con
import win32api


mon = {'left': 1480, 'top': 1318, 'width': 150, 'height': 150}

if __name__ == "__main__":
    mark = cv2.imread('arrow.jpg', cv2.IMREAD_COLOR)
    mark=cv2.cvtColor(mark, cv2.COLOR_BGR2RGB)
    #pyautogui.displayMousePosition()

    hwnd = int(sys.argv[2])

    with mss() as sct:
        while True:
            screenShot = sct.grab(mon)
            cur = cv2.cvtColor(np.array(screenShot), cv2.COLOR_BGR2RGB)
            res = cv2.matchTemplate(cur, mark, cv2.TM_CCOEFF_NORMED)
            loc = np.where(res >= 0.98)
            if loc[0].any():
                win32api.PostMessage(hwnd, win32con.WM_KEYDOWN, 0x20, 0)
                win32api.PostMessage(hwnd, win32con.WM_KEYUP, 0x20, 0)
                time.sleep(0.5)
