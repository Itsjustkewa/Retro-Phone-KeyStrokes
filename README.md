# Retro-Phone-KeyStrokes
A mini challenge conducted at [Veriff's](https://instagram.com/insideveriff?igshid=YmMyMTA2M2Y=) pycon.

## A console application written in CSharp. 

### The Challenge
Many many years ago (seriously a long time ago) mobile phones had no QWERTY keyboard, just the numeric one. To enter a message on a device you need to make a few combinations of the 10 numeric keys to be able to type words. Each number is associated with a set of letters as follows:

|Letters|Number|
|-------|------|
|ABC    |  2   |
|DEF    |  3   |
|GHI    |  4   |
|JKL    |  5   |
|MNO    |  6   |
|PQRS   |  7   |
|TUV    |  8   |
|WXYZ   |  9   |
|Space  |  0   |

In this keyboard, you may need to press the same button multiple times to display the letter that you want. If I want to write DOG I need to press the number 3 one time, the number 6 three times and the number 4 one time, so DOG is equal to the 36664 sequence.

#### First part of the challenge:
Create a method that encodes words into sequence numbers, meaning that it returns the
sequence of numbers that need to be pressed in order to form words

Here are some examples for your first round of tests:

DOJO = 36665666

PYTEST = 799983377778

TESTS = 833777787777

Here are some more examples for your second round of tests. Note that you should use _ to separate different letters under the same number:

CODE = 2226663_33

PUZZLE = 7889999_999955533

For the third round of tests, let's try out some phrases:

I LIKE PYTHON = 4440555444553307999844666_66

PAIR PROGRAMMING = 7244477707_777666477726_6444664

#### Second part of the challenge:
Now that you can encode messages, try to build a message decoder, meaning that it will receive sequence of numbers and return the words hidden in the sequence.
