import sys
from pywinauto import *

windows = application.findwindows.find_windows(title_re=".*LOST.*ARK.*")
hwnd=windows[len(windows)-1]
sys.stdout.buffer.write(bytearray(str(hwnd), "utf-8"))
