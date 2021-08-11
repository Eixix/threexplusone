threexplusone :: Int -> [Int]
threexplusone x
  | x == 1 = [1]
  | odd x = x : threexplusone (3*x+1)
  | otherwise = x : threexplusone (div x 2)

main :: IO ()
main = do
  print (map threexplusone [1..1000])