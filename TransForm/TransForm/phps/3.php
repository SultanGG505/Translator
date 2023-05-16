<?php
    $i = 0;

    function factor($x){
        if ($x == 0)
            return 1;
        return $x * factor($x - 1);
    }

    while( $i < 10) {
        $i++;
        if( $i == 3 )break;
        }
    echo ("Loop stopped at i = $i" );
    $a = fact($i)
    echo $a
?>
