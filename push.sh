read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Refactor . Refactor to create Generic Class to take in 3 variables of Generic Type"
git push origin $a
git checkout master
git merge $a
git push origin master --force
