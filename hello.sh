# this is a comment
echo "Hello"
echo "World"

msg="Hello Student"

echo $msg

echo What is your name?
read userInput
echo Hello $userInput, "welcome to class!"

for var in 1 2 3 4 5
do
	echo $var
	echo This variable currently holds : $var
done

for i in {1..10..1} #starting number ending number incrementing number
do
	echo $i
done

for words in Hello World Test Hi What
do
	Echo $words
done

#while loops
condition="true"
 
while [ "$condition" != "false" ] 
do
	echo "Do you want to repeat? (true or false)"
	read condition
	echo "You typed: $condition"
done

#if statement

echo pick a number
read number
if [ $number > 5 ]
then
	echo "$number is greater than 5"
fi
