class Circle:
  def __init__(self, radius):
    self.radius = radius
    self._area = 0
    self._circumference = 0

def calculate(self):
    self._area = 3.14 * self.radius**2
    self._circumference = 2 * self.radius * 3.14

def getArea(self):
  return self._area

def getCircumference(self):
  return self._circumference

def main():
  rad = int(input("Enter Radius: "))
  circle = Circle(rad)
  circle.calculate()
  print("Area:", circle.getArea())
  print("Circumference:", circle.getCircumference())

if __name__ == "__main__":
  main()