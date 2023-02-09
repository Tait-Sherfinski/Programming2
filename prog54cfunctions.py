def calcArea(radius):
  return radius**2 * 3.14

def calcCirc(radius):
  return 2 * 3.14 * radius

def areacirc(radius):
  area = calcArea(radius)
  circumference = calcCirc(radius)
  return area, circumference

def main():
  radius = int(input("Enter Radius: "))
  a, c = areacirc(radius)
  print(f"area: {a}\n circumference: {c}")

if __name__ == "__main__":
  main()