#!/usr/bin/php
<?php
function threexplusone($x) 
{
	if ($x == 1) {
		return [1];
	} else if ($x % 2 == 1) {
		return array_merge(threexplusone(3 * $x + 1), [$x]);
	} else {
		return array_merge(threexplusone($x / 2), [$x]);
	}
}

print_r(array_map('threexplusone', range(1, 10000)));