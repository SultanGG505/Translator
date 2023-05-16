<?php
    $numbers = [12, 43, 91, 16];
    function sum_cifr($x){
        $a=$x;
        $sum=0;
        if (is_int($x) == true){
            while($a>0){
                $sum = $sum + $a%10
                $a = intdiv($a,10)
            }
            return $sum
        }
    }
    foreach ($numbers as $n){
        if ($n % 2 == 0)
            echo sum_cifr($n)
        else
            echo "Number is wrong"
    }
?>