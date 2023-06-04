<?php
include_once('connects.php');

$usermail = $_GET['usermail'];
$newpass = $_GET['newpass'];

$result = mysqli_query($con, "UPDATE user_table SET pword='$newpass' WHERE usermail = '$usermail'");

if (!$row = mysqli_fetch_assoc($result)) {
    echo "0";
} else {
    echo "1";	
}

mysqli_close($con);
?>