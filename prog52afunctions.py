def calcArea(len, wid):
  return len * wid

def calcPerim(len, wid):
  return 2 * len + 2 * wid

def areaPerim(len, wid):
  area = calcArea(len, wid)
  perim = calcPerim(len, wid)
  return area, perim

def main():
  length = int(input("Enter Length: "))
  width = int(input("Enter Width: "))
  a, p = areaPerim(length, width)
  print(f"area: {a}\n perimeter: {p}")

if __name__ == "__main__":
  main()