<?php

include_once('connects.php');

$uname = $_GET['uname'];
$pword = $_GET['pword'];
$usermail = $_GET['usermail'];


    $query = "INSERT INTO user_table (uname, pword, usermail) VALUES ('$uname', '$pword', '$usermail')";

mysqli_close($con);
?>
