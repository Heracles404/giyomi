<?php
include_once('connects.php');

$username = $_GET['username'];
$bookName = $_GET['bookName'];
$paymentmode = $_GET['paymentmode'];
$referencenumber = $_GET['referencenumber'];
$phoneNumber = $_GET['phoneNumber'];

$query = "INSERT INTO pre_order_table (username, price, bookName, referencenumber, paymentmode, phoneNumber) VALUES ('$uname', '800', '$bookName', '$referencenumber', '$paymentmode', '$phoneNumber')";

mysqli_close($con);
?>