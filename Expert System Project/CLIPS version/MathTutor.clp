;;;====================================================== 
;;;	
;;;	Instructions
;;;	
;;;
;;;
;;;	Developers: 
;;;	
;;;	Ahmed Yusuf Patel (27342514)
;;;	Arno Pretorius (26056569)	
;;;
;;;	The user will be prompted to select the operator (1,2,3 or 4) and then prompted again 
;;;	to which the user must press q to continue
;;;
;;;	Facts must be stored of the specific rule based criteria
;;;	e.g.
;;;	Instructions:
;;;
;;;	The user will be prompted to select the operator (1,2,3 or 4) and then prompted again 
;;;	to which the user must press q to continue
;;;
;;;	Facts must be stored of the specific rule based criteria
;;;	e.g.
;;;
;;;	A = Addition
;;;	2/3/4 = number of numbers
;;;	10Q/25Q = number of questions
;;;	E/H = difficulty 
;;;
;;;	examples
;;;
;;;	A210QE
;;;	A225QE
;;;	A410QH
;;;	A310QE
;;;	A325QE 
;;;	A425QE
;;;====================================================== 

(deffunction prompt-iterator (?user-prompt $?permissableVal) 
   (printout t ?user-prompt) 
   	(bind ?user-result (read)) 
   (if (lexemep ?user-result)  
       		then (bind ?user-result (lowcase ?user-result))) 
   (while (not (member ?user-result ?permissableVal)) do 
      	(printout t ?user-prompt) 
      		(bind ?user-result (read)) 
   (if (lexemep ?user-result)  
         	 then (bind ?user-result (lowcase ?user-result)))) 
   ?user-result) 

;;;======================================================  
(deffunction prompt-query (?user-prompt) 
  	 (bind ?output-given (prompt-iterator ?user-prompt y n)) 
   (if(eq ?output-given y)
       		then TRUE  
       			else FALSE))

;;;====================================================== 
 
(defrule main-introduction  
   =>    
	(printout t "Welcome to our expert system!" crlf)
			
		(printout t "First of all choose (ONE) of the operators below, by selecting the appropriate key value" crlf)
				(printout t "Enjoy!" crlf)
	        	(printout t "1 = Addition 2 = Subtraction 3 = Division 4 = Multiplication" crlf)
				(printout t " after you press "1, 2 or 3" then please type in (" Start ") to start the program " crlf)
					(printout t "Thank you and please enjoy!" crlf)
        
	(bind ?specifications 5) 
        
	(while TRUE  
	
	(printout t "Operator:")  
        
	(bind ?specifications (read)) 
        
	(if (eq ?specifications Start) then (break)) 
		(switch ?specifications   
        
	(case 1 then (assert (operator-type user addition-tp))) 
	(case 2 then (assert (operator-type user subtraction-tp))) 
	(case 3 then (assert (operator-type user division-tp))) 	
	(case 4 then (assert (operator-type user multiplication-tp))) 	

;;;====================================================== 
		
	(case 5 then (assert(add-Q1c user correct-answer)))
		(case 6 then (assert(add-Q1w user wrong-answer)))
	
	(case 7 then (assert(add-Q2c user correct-answer)))
		(case 16 then (assert(add-Q2w user wrong-answer)))

	(case 8 then (assert(add-Q3c user correct-answer)))

;;;====================================================== 
	
	(case 9 then (assert (num-quant-2 user 2-numbers)))
		(case 10 then (assert (num-quant-3 user 3-numbers)))
			(case 11 then (assert (num-quant-4 user 4-numbers)))
 
	(case 12 then (assert (q-num-10 user 10-questions)))
	        (case 13 then (assert (q-num-25 user 25-questions)))
	
	(case 14 then (assert(d-easy user easy-difficulty))) 
		(case 15 then (assert(d-hard user hard-difficulty)))

		(default none))))

;;;====================================================== 
(defrule nSelection-addition  
   (operator-type user addition-tp)
	(not (num-quant-2 user ?))
	(not (num-quant-3 user ?))
	(not (num-quant-3 user ?))
   => 
     (if (prompt-query "Do you want to solve two numbers?") then (assert (num-quant-2 user 2-numbers))
	else(if(prompt-query "Do you want to solve three numbers?") then (assert (num-quant-3 user 3-numbers))
		else(if(prompt-query "Do you want to solve four numbers?") then (assert (num-quant-4 user 4-numbers))
      else (assert (ans "----"))))))

(defrule qSelection-addition  
   (operator-type user addition-tp)
	(not (q-num-10 user ?))
	(not (q-num-25 user ?))
   => 
     (if (prompt-query "Do you want to do 10 questions?") then (assert (q-num-10 user 10-questions))
	else(if(prompt-query "Do you want to 25 questions?") then (assert (q-num-25 user 25-questions))
      else (assert (ans "----")))))

(defrule dSelection-addition  
   (operator-type user addition-tp)
	(not (d-easy user ?))
	(not (d-hard user ?))
	(not(add-Q1c user ?))
	(not(add-Q1w user ?))
   => 
     (if (prompt-query "Would you like to answer on easy mode?") then (assert (d-easy user easy-difficulty))
	(printout t " 9 + 2 = 11, 2 + 8 =10, 6 + 7 = 13, 5 + 9 = 14, 0 + 7 = 7, 0 + 0 = 0,
	9 + 9 = 18, 2 + 8 = 10, 7 + 8 = 15, 0 + 2 = 2, 0 + 8 = 8, 3 + 8 = 11 " crlf)
	(printout t "good, but you still need practice" crlf)
	else(if(prompt-query "Would you like to answer on hard mode?") then (assert (d-hard user hard-difficulty))
	(printout t " 9 + 2 = 11, 2 + 8 =10, 6 + 7 = 13, 5 + 9 = 14, 0 + 7 = 7, 0 + 0 = 0,
	9 + 9 = 18, 2 + 8 = 10, 7 + 8 = 15, 0 + 2 = 2, 0 + 8 = 8, 3 + 8 = 11 " crlf)
     (if(prompt-query "Do you agree with the following answers?") then (assert (add-Q1c user correct-answer))
		(printout t "good, but you still need practice" crlf)
      else (assert (ans "----"))))))

;;;====================================================== 

(defrule nSelection-subtraction  
   (operator-type user subtraction-tp)
	(not (num-qunat-2 user ?))
	(not (num-quant-3 user ?))
	(not (num-quant-4 user ?))
   => 
     (if (prompt-query "Do you want to solve two numbers?") then (assert (num-quant-2 user 2-numbers))
	else(if(prompt-query "Do you want to solve three numbers?") then (assert (num-quant-3 user 3-numbers))
		else(if(prompt-query "Do you want to solve four numbers?") then (assert (num-quant-4 user 4-numbers))
      else (assert (ans "----"))))))

(defrule qSelection-subtraction  
   (operator-type user subtraction-tp)
	(not (q-num-10 user ?))
	(not (q-num-25 user ?))
   => 
     (if (prompt-query "Do you want to do 10 questions?") then (assert (q-num-10 user 10-questions))
	else(if(prompt-query "Do you want to 25 questions?") then (assert (q-state25 user 25-questions))
      else (assert (ans "----")))))

(defrule dSelection-subtraction 
   (operator-type user subtraction-tp)
	(not (d-easy user ?))
	(not (d-hard user ?))
	(not(add-Q1c user ?))
	(not(add-Q1w user ?))
   => 
     (if (prompt-query "Would you like to answer on easy mode?") then (assert (d-easy user easy-difficulty))
	(printout t " 9 - 2 = 7, 2 - 8 =-6, 6 - 7 = -1, 15 - 9 = 6, 0 - 0 = 0, 0 - 0 = 0,
	19 - 9 = 0, 10 - 8 = 2, 9 - 8 = 1, 0 - 2 = -2, 0 - 8 = -8, 25 - 8 = 17 " crlf)
    (if(prompt-query "Do you agree with the following answers?") then (assert (add-Q1c user correct-answer))
	(printout t "good, but you still need practice" crlf)
	else(if(prompt-query "Would you like to answer on hard mode?") then (assert (d-hard user hard-difficulty))
	(printout t " 9 - 2 = 7, 2 - 8 =-6, 6 - 7 = -1, 15 - 9 = 6, 0 - 0 = 0, 0 - 0 = 0,
	19 - 9 = 0, 10 - 8 = 2, 9 - 8 = 1, 0 - 2 = -2, 0 - 8 = -8, 25 - 8 = 17 " crlf)
     (if(prompt-query "Do you agree with the following answers?") then (assert (add-Q1c user correct-answer))
		(printout t "good, but you still need practice" crlf)
      else (assert (ans "----")))))))

;;;====================================================== 

(defrule nSelection-division 
   (operator-type user division-tp)
	(not (num-quant-2 user ?))
	(not (num-quant-3 user ?))
	(not (num-quant-4 user ?))
   => 
     (if (prompt-query "Do you want to solve two numbers?") then (assert (num-quant-2 user 2-numbers))
	else(if(prompt-query "Do you want to solve three numbers?") then (assert (num-quant-3 user 3-numbers))
		else(if(prompt-query "Do you want to solve four numbers?") then (assert (num-quant-4 user 4-numbers))
      else (assert (ans "----"))))))

(defrule qSelection-division  
   (operator-type user division-tp)
	(not (q-num-10 user ?))
	(not (q-num-25 user ?))
   => 
     (if (prompt-query "Do you want to do 10 questions?") then (assert (q-num-10 user 10-questions))
	else(if(prompt-query "Do you want to 25 questions?") then (assert (q-num-25 user 25-questions))
      else (assert (ans "----")))))

(defrule dSelection-division 
   (operator-type user division-tp)
	(not (d-easy user ?))
	(not (d-hard user ?))
	(not(add-Q1c user ?))
	(not(add-Q1w user ?))
   => 
     (if (prompt-query "Would you like to answer on easy mode?") then (assert (d-easy user easy-difficulty))
	(printout t " 8 / 2 = 4, 4 / 2  = 2, 24 / 6 = 8, 12 / 3 = 3, 0 / 0 = 0, 0 / 0 = 0,
	9 / 9 = 1, 10 / 8 = 2, 8 / 8 = 1, 4 / 2 = 2, 16 / 8 = 2, 6 + 3 = 2 " crlf)
   (if(prompt-query "Do you agree with the following answers?") then (assert (add-Q1c user correct-answer))
	(printout t "good, but you still need practice" crlf)
	else(if(prompt-query "Would you like to answer on hard mode?") then (assert (d-hard user hard-difficulty))
	(printout t " 8 / 2 = 4, 4 / 2  = 2, 24 / 6 = 8, 12 / 3 = 3, 0 / 0 = 0, 0 / 0 = 0,
	9 / 9 = 1, 10 / 8 = 2, 8 / 8 = 1, 4 / 2 = 2, 16 / 8 = 2, 6 + 3 = 2 " crlf)
     (if(prompt-query "Do you agree with the following answers?") then (assert (add-Q1c user correct-answer))
		(printout t "good but you still need practice" crlf)
      else (assert (ans "----")))))))
		
;;;====================================================== 

(defrule nSelection-multiplication
   (operator-type user multiplication-tp)
	(not (num-quant-2 user ?))
	(not (num-quant-3 user ?))
	(not (num-quant-4 user ?))
   => 
     (if (prompt-query "Do you want to solve two numbers?") then (assert (num-quant-2 user 2-numbers))
	else(if(prompt-query "Do you want to solve three numbers?") then (assert (num-quant-3 user 3-numbers))
		else(if(prompt-query "Do you want to solve four numbers?") then (assert (num-quant-4 user 4-numbers))
      else (assert (ans "----"))))))

(defrule qSelection-multiplication
   (operator-type user multiplication-tp)
	(not (q-num-10 user ?))
	(not (q-num-25 user ?))
   => 
     (if (prompt-query "Do you want to do 10 questions?") then (assert (q-num-10 user 10-questions))
	else(if(prompt-query "Do you want to 25 questions?") then (assert (q-num-25 user 25-questions))
      else (assert (ans "----")))))

(defrule dSelection-division 
   (operator-type user multiplication-tp)
	(not (d-easy user ?))
	(not (d-hard user ?))
	(not(add-Q1c user ?))
	(not(add-Q1w user ?))
   => 
     (if (prompt-query "Would you like to answer on easy mode?") then (assert (d-easy user easy-difficulty))
	(printout t " 9 * 2 = 11, 2 * 8 = 10, 2 * 7 = 13, 5 * 9 = 14, 0 * 7 = 0, 0 * 0 = 0,
	9 * 9 = 81, 2 * 8 = 16, 7 * 8 = 56, 0 * 2 = 0, 0 * 8 = 0, 3 * 8 = 24 " crlf)
(if(prompt-query "Do you agree with the following answers?") then (assert (add-Q1c user correct-answer))
	(printout t "good, but you still need practice" crlf)
	else(if(prompt-query "Would you like to answer on hard mode?") then (assert (d-hard user hard-difficulty))
	(printout t " 9 * 2 = 11, 2 * 8 = 10, 2 * 7 = 13, 5 * 9 = 14, 0 * 7 = 0, 0 * 0 = 0,
	9 * 9 = 81, 2 * 8 = 16, 7 * 8 = 56, 0 * 2 = 0, 0 * 8 = 0, 3 * 8 = 24 " crlf)
     (if(prompt-query "Do you agree with the following answers?") then (assert (add-Q1c user correct-answer))
		(printout t "good, but you still need practice" crlf)
      else (assert (ans "----")))))))

;;;====================================================== 










