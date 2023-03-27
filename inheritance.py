class animal:
  def __init__(self, name, age):
    self.name= name
    self.age = age

  def sayhi(self):
    print("Hi")


class Cat(animal):
  def __init__(self, name, age, sound):
    animal.__init__(name, age)
    self.sound = sound

def saysound(self):
  print(self.sound)


cat = Cat("Billy", 5, "Meow")
cat.sayhi
cat.saysound