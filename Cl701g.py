class person:
  def __init__(self, fn, ln):
    self._first = fn
    self._last = ln

  def getName(self):
    return self._first + " " + self._last


class student(person):
  def __init__(self, fn, ln, gpa):
    super().__init__(fn, ln, gpa)
    self.gpa = gpa

class teacher(person):
  def __init__(self, fn, ln, numstu):
    super().__init__(fn, ln)
    self.numStudents = numstu


class admin(person):
  def __init__(self, fn, ln, favW):
    super().__init__(fn, ln)
    self.favWord = favW 