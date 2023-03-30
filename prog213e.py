age = int(input("Age: "))
distribution = 0
percentage = 0.0
group = "0"

if age < 20:
  group = "<20"
  distribution = 3
  percentage = 17.65
if age > 19 and age < 40:
  group = "20-39"
  distribution = 5
  percentage = 29.41
if age > 39 and age < 60:
  group = "<40-59"
  distribution = 4
  percentage = 23.53
if age > 59 and age < 80:
  group = "60-79"
  distribution = 3
  percentage = 17.65
if age > 79:
  group = ">79"
  distribution = 2
  percentage = 11.76

print("Age Group: " + group + "Distribution: " + str(distribution) + "Percentage: " + str(percentage))