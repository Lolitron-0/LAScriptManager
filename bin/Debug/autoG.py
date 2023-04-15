import time
import win32con
import sys

import win32api

hwnd = int(sys.argv[2])

while True:
    win32api.PostMessage(hwnd, win32con.WM_KEYDOWN, 0x47, 0)
    win32api.PostMessage(hwnd, win32con.WM_KEYUP, 0x47, 0)
    time.sleep(0.03)
