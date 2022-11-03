# Need
# pip install cairosvg
# pip install Pillow

import os

import cairosvg
from PIL import Image

_svg = r"assets/VLBI Terminal Icon.svg"
_temp = r"assets/icon_temp.png"
_ico = r"VLBI Terminal Icon.ico"

if __name__ == '__main__':
    cairosvg.svg2png(url=_svg, write_to=_temp,parent_height=128, parent_width=128)
    img = Image.open(_temp)
    img.save(_ico, sizes=[(128, 128)])
    os.remove(_temp)
