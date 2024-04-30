<!-- Fibonacci -->
<?php
$limit = 20;
$n1 = 0;
$n2 = 1;

echo $n1 . "\n";
echo $n2 . "\n";

while ($n2 < $limit) {
    $nextNumber = $n1 + $n2;
    echo $nextNumber . "\n";
    $n1 = $n2;
    $n2 = $nextNumber;
}
?>

