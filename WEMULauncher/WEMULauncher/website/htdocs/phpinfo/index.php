<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta http-equiv="content-type" content="text/html; charset=utf-8" />
	<title>php7webserver</title>
	<meta name="keywords" content="" />
	<meta name="description" content="" />
	<link href="style.css" rel="stylesheet" type="text/css" media="screen" />
</head>
<body>
	<div id="container">
		<img id="header" src="images/header.png">
		<ul id="menu">
			<li>
				<div id="menuleft"></div>
				<a id="menua" href="http://">
					php7webserver
				</a>
				<div id="menuright"></div>
			</li>
			<li>
				<div id="menuleft"></div>
				<a id="menua" href="http://www">
					php7webserver
				</a>
				<div id="menuright"></div>
			</li>
		</ul>
		<div id="topcontent"></div>
		<div id="content">
			<div id="contentleft">

				<h1>php7webserver</h1>
				<p>
					<ul>
						<li>Php <?php echo phpversion(); ?></li>
						<li>Httpd <?php echo apache_get_version(); ?></li>
					</ul>
				</p>
				<h1>PHP <?php echo phpversion(); ?> info</h1>
				<?php
					ob_start();
					phpinfo();
					$i = ob_get_contents();
					ob_end_clean();
					
					echo ( str_replace ( "module_Zend Optimizer", "module_Zend_Optimizer", preg_replace ( '%^.*<body>(.*)</body>.*$%ms', '$1', $i ) ) ) ;
				?>
			
			</div>
			<a href="http://www" id="banner"></a>
			<br style="clear:both">
		</div>
	</div>
</body>
</html>
		