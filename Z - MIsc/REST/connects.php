<?php

$DB_HOST = "www.db4free.net";
$DB_USER = "chaaan30"; 
$DB_PASS = "giyomiserver"; 
$DB_NAME = "atheniumtable";

$con=mysqli_connect($DB_HOST,$DB_USER,$DB_PASS,$DB_NAME);

if (!$con)
{
    die( "Unable to select database");
}

?>