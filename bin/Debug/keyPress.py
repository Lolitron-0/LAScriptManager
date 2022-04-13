import time

import keyboard
import win32gui
import win32con
import win32api
import re
from sys import argv

import winsound

PRESS = False
KEY = 0x47


def find_window_by_search(pattern):
    window_list = []
    win32gui.EnumWindows(lambda hWnd, param: param.append(hWnd), window_list)
    for each in window_list:
        if re.search(pattern, win32gui.GetWindowText(each)) is not None:
            return each
    return None


if __name__ == '__main__':
    keyboard.add_hotkey("F3", switch)
    keyboard.add_hotkey("ctrl+g", lambda: set_key(0x47))
    keyboard.add_hotkey("ctrl+space", lambda: set_key(0x20))
    hwnd = find_window_by_search("LOST")
    print(hwnd)
    while True:
        if PRESS:
            win32api.PostMessage(hwnd, win32con.WM_KEYDOWN, KEY, 0)
            win32api.PostMessage(hwnd, win32con.WM_KEYUP, KEY, 0)
        time.sleep(0.02)
