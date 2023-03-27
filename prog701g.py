from Cl701g import *

def main():
  try:
    people = []
    with open("data/prog701g.dat", "r") as f:
        num = int(f.readline())
        while num != 99:
          fn = f.readline()
          ln = f.readline
        if num == 1:
          gpa = float(f.readline)
          p = student(fn, ln, gpa)
          people.append(p)
        elif num == 2:
          numstu = int(f.readline)
          p = teacher(fn, ln, numstu)
          people.append(p)
        elif num == 3:
          favW = f.readline().strip
          p = admin(fn, ln, favW)
          people.append(p)
        num = int(f.readline())

      tot = 0.0
      cnt = 0
      totstus = 0
      large = ""
      sm = "kgjslkfdjglkfdjglkdjfglkjdgflkjdfskgljglkjlkgdjsklgjdsklgjldsglkjfdslkgsdjglksdjglkdsjgkljdslkgjdflkgjlkdjglkdsjklsdj"

    for person in people:
      if isinstance(person, student):
        tot += person.gpa
        cnt += 1
      if isinstance(person, teacher):
        totstus += person.numStudents
      if isinstance(person, admin):
        favW = person.favWord
        if len(favW) > len(large):
          large = favW
        if len(favW) < len(sm):
          sm = favW

      print("Average student GPA: ", round(tot/cnt, 2))
      print("Total number of students taught ", totstus)
      print("Smallest favorite admin word ", sm)
      print("Largest favorite admin word ", large)

  except Exception as e:
    print("Error:", e)


if __name__ == "__main__":
  main()