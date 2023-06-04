<?php
include_once('connects.php');

$username = $_GET['uname'];
$usermail = $_GET['usermail'];

$result = mysqli_query($con, "SELECT * FROM user_table WHERE uname = '$username' OR usermail = '$usermail'");

if (!$row = mysqli_fetch_assoc($result)) {
    echo "0";
} else {
    echo "1";	
}

mysqli_close($con);
?>
