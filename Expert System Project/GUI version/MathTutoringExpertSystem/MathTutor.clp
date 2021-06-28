(deftemplate mathTutor (slot numbers2)
(slot numbers3)
(slot numbers4)
(slot operatorAddition)
(slot operatorSubtraction)
(slot operatorDivision)
(slot operatorMultiplication) 
(slot questions10)
(slot questions25)
(slot difficultyEasy)
(slot difficultyHard))

(deffacts m-Details (mathTutor
(numbers2 2)
(numbers3 3)
(numbers4 4)
(operatorAddition Add)
(operatorSubtraction Sub)
(operatorDivision Div)
(operatorMultiplication Multi)
(questions10 10)
(questions25 25)
(difficultyEasy Easy)
(difficultyHard Hard)))

(defrule addition-1
=>
(printout t "Enter the operator(Add): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Add)(eq ?n_value 2)(eq ?q_value 10)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))

(open "A210QE.dat" computeData "r")

(close))



(defrule addition-2
=>
(printout t "Enter the operator(Add): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Add)(eq ?n_value 2)(eq ?q_value 25)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))

=>
(printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)

(open "A225QE.dat" computeData "r")

(close))

(defrule addition-3
=>
(printout t "Enter the operator(Add): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Add)(eq ?n_value 3)(eq ?q_value 10)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>
(printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)

(open "A310QE.dat" computeData "r")

(close))

(defrule addition-4
=>
(printout t "Enter the operator(Add): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Add)(eq ?n_value 3)(eq ?q_value 25)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>
(printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)

(open "A325QE.dat" computeData "r")

(close))


(defrule addition-5
=>
(printout t "Enter the operator(Add): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Add)(eq ?n_value 4)(eq ?q_value 10)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>
(printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)

(open "A410QE.dat" computeData "r")

(close))

(defrule addition-6
=>
(printout t "Enter the operator(Add): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Add)(eq ?n_value 4)(eq ?q_value 25)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>
(printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)

(open "A425QE.dat" computeData "r")

(close))

(defrule addition-7
=>
(printout t "Enter the operator(Add): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Add)(eq ?n_value 2)(eq ?q_value 10)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>

(open "A210QH.dat" computeData "r")


(close))


(defrule addition-8
=>
(printout t "Enter the operator(Add): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Add)(eq ?n_value 2)(eq ?q_value 25)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>

(open "A225QH.dat" computeData "r")

(close))

(defrule addition-9
=>
(printout t "Enter the operator(Add): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Add)(eq ?n_value 3)(eq ?q_value 10)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>

(open "A310QH.dat" computeData "r")

(close))

(defrule addition-10
=>
(printout t "Enter the operator(Add): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Add)(eq ?n_value 3)(eq ?q_value 25)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>

(open "A325QH.dat" computeData "r")

(close))

(defrule addition-11
=>
(printout t "Enter the operator(Add): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Add)(eq ?n_value 4)(eq ?q_value 10)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>
(printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)

(open "A410QH.dat" computeData "r")

(close))

(defrule addition-12
=>
(printout t "Enter the operator(Add): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Add)(eq ?n_value 4)(eq ?q_value 25)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>
(printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)

(open "A425QH.dat" computeData "r")

(close))


(defrule subtract-1
=>
(printout t "Enter the operator(Sub): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Sub)(eq ?n_value 2)(eq ?q_value 10)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>
(printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)

(open "S210QE.dat" computeData "r")


(close))


(defrule subtract-2
=>
(printout t "Enter the operator(Sub): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Sub)(eq ?n_value 2)(eq ?q_value 25)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>
(printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)

(open "S225QE.dat" computeData "r")

(close))


(defrule subtract-3
=>
(printout t "Enter the operator(Sub): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Sub)(eq ?n_value 3)(eq ?q_value 10)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>
(printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)

(open "S310QE.dat" computeData "r")

(close))

(defrule subtract-4
=>
(printout t "Enter the operator(Sub): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Sub)(eq ?n_value 3)(eq ?q_value 25)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>
(printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)

(open "S325QE.dat" computeData "r")

(close))


(defrule subtract-5
=>
(printout t "Enter the operator(Sub): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Sub)(eq ?n_value 4)(eq ?q_value 10)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>
(printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)

(open "S410QE.dat" computeData "r")

(close))

(defrule subtract-6
=>
(printout t "Enter the operator(Sub): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Sub)(eq ?n_value 4)(eq ?q_value 25)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>
(printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)

(open "S425QE.dat" computeData "r")

(close))


(defrule subtract-7
=>
(printout t "Enter the operator(Sub): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Sub)(eq ?n_value 2)(eq ?q_value 10)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>
(printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)

(open "S210QH.dat" computeData "r")


(close))


(defrule subtract-8
=>
(printout t "Enter the operator(Sub): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Sub)(eq ?n_value 2)(eq ?q_value 25)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>
(printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)

(open "S225QH.dat" computeData "r")

(close))


(defrule subtract-9
=>
(printout t "Enter the operator(Sub): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Sub)(eq ?n_value 3)(eq ?q_value 10)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>
(printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)

(open "S310QH.dat" computeData "r")

(close))

(defrule subtract-10
=>
(printout t "Enter the operator(Sub): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Sub)(eq ?n_value 3)(eq ?q_value 25)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>
(printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)

(open "S325QH.dat" computeData "r")

(close))

(defrule subtract-11
=>
(printout t "Enter the operator(Sub): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Sub)(eq ?n_value 4)(eq ?q_value 10)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>

(open "S410QH.dat" computeData "r")

(close))

(defrule subtract-12
=>
(printout t "Enter the operator(Sub): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Sub)(eq ?n_value 4)(eq ?q_value 25)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>

(open "S425QH.dat" computeData "r")

(close))

(defrule multiply-1
=>
(printout t "Enter the operator(Multi): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Multi)(eq ?n_value 2)(eq ?q_value 10)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>

(open "M210QE.dat" computeData "r")


(close))


(defrule multiply-2
=>
(printout t "Enter the operator(Multi): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Multi)(eq ?n_value 2)(eq ?q_value 25)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>

(open "M225QE.dat" computeData "r")

(close))

(defrule multiply-3
=>
(printout t "Enter the operator(Multi): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Multi)(eq ?n_value 3)(eq ?q_value 10)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>

(open "M310QE.dat" computeData "r")

(close))

(defrule multiply-4
=>
(printout t "Enter the operator(Multi): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Multi)(eq ?n_value 3)(eq ?q_value 25)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>

(open "M325QE.dat" computeData "r")

(close))

(defrule multiply-5
=>
(printout t "Enter the operator(Multi): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Multi)(eq ?n_value 4)(eq ?q_value 10)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>

(open "M410QE.dat" computeData "r")

(close))

(defrule multiply-6
=>
(printout t "Enter the operator(Multi): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Multi)(eq ?n_value 4)(eq ?q_value 25)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>

(open "M425QE.dat" computeData "r")

(close))


(defrule multiply-7
=>
(printout t "Enter the operator(Multi): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Multi)(eq ?n_value 2)(eq ?q_value 10)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>


(open "M210QH.dat" computeData "r")


(close))


(defrule multiply-8
=>
(printout t "Enter the operator(Multi): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Multi)(eq ?n_value 2)(eq ?q_value 25)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>

(open "M225QH.dat" computeData "r")

(close))

(defrule multiply-9
=>
(printout t "Enter the operator(Multi): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Multi)(eq ?n_value 3)(eq ?q_value 10)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>

(open "M310QH.dat" computeData "r")

(close))

(defrule multiply-10
=>
(printout t "Enter the operator(Multi): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Multi)(eq ?n_value 3)(eq ?q_value 25)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>

(open "M325QH.dat" computeData "r")

(close))

(defrule multiply-11
=>
(printout t "Enter the operator(Multi): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Multi)(eq ?n_value 4)(eq ?q_value 10)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>


(open "M410QH.dat" computeData "r")

(close))

(defrule multiply-12
=>
(printout t "Enter the operator(Multi): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Multi)(eq ?n_value 4)(eq ?q_value 25)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>


(open "M425QH.dat" computeData "r")

(close))

(defrule division-1
=>
(printout t "Enter the operator(Div): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Div)(eq ?n_value 2)(eq ?q_value 10)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>


(open "D210QE.dat" computeData "r")


(close))


(defrule division-2
=>
(printout t "Enter the operator(Div): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Div)(eq ?n_value 2)(eq ?q_value 25)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>


(open "D225QE.dat" computeData "r")

(close))

(defrule division-3
=>
(printout t "Enter the operator(Div): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Div)(eq ?n_value 3)(eq ?q_value 10)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>

(open "D310QE.dat" computeData "r")

(close))

(defrule division-4
=>
(printout t "Enter the operator(Div): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Div)(eq ?n_value 3)(eq ?q_value 25)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>

(open "D325QE.dat" computeData "r")

(close))

(defrule division-5
=>
(printout t "Enter the operator(Div): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Div)(eq ?n_value 4)(eq ?q_value 10)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>


(open "D410QE.dat" computeData "r")

(close))

(defrule division-6
=>
(printout t "Enter the operator(Div): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Div)(eq ?n_value 4)(eq ?q_value 25)(eq ?d_value Easy))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>

(open "D425QE.dat" computeData "r")

(close))

(defrule division-7
=>
(printout t "Enter the operator(Div): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Div)(eq ?n_value 2)(eq ?q_value 10)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>
(printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)

(open "D210QH.dat" computeData "r")


(close))


(defrule division-8
=>
(printout t "Enter the operator(Div): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Div)(eq ?n_value 2)(eq ?q_value 25)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>

(open "D225QH.dat" computeData "r")

(close))

(defrule division-9
=>
(printout t "Enter the operator(Div): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Div)(eq ?n_value 3)(eq ?q_value 10)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))

=>

(open "D310QH.dat" computeData "r")

(close))

(defrule division-10
=>
(printout t "Enter the operator(Div): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Div)(eq ?n_value 3)(eq ?q_value 25)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))
=>


(open "D325QH.dat" computeData "r")

(close))

(defrule division-11
=>
(printout t "Enter the operator(Div): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))
(if(and(eq ?a_value Div)(eq ?n_value 4)(eq ?q_value 10)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))	
=>

(open "D410QH.dat" computeData "r")

(close))

(defrule division-12
=>
(printout t "Enter the operator(Div): ")
(bind ?a_value (read))

(printout t "Enter the number of numbers(2, 3 or 4): ")
(bind ?n_value (read))

(printout t "Enter the number of questions(10 or 25): ")
(bind ?q_value (read))

(printout t "Enter the difficulty(Easy or Hard): ")
(bind ?d_value (read))

(if(and(eq ?a_value Div)(eq ?n_value 4)(eq ?q_value 25)(eq ?d_value Hard))
	then (printout t ?a_value "  " ?n_value "  " ?q_value "  " ?d_value " " crlf)
		else(printout "error"))

=>

(open "D425QH.dat" computeData "r")
(close))
