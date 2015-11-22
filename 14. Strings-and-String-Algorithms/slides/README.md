<!-- section start -->

<!-- attr: {id: 'title', class: 'slide-title', hasScriptWrapper: true} -->
# Algorithms on Strings
## Searching
<div class="signature">
    <p class="signature-course">Data Structures and Algorithms</p>
    <p class="signature-initiative">Telerik Software Academy</p>
    <a href="http://academy.telerik.com" class="signature-link">http://academy.telerik.com</a>
</div>

<!-- section start -->

<!-- attr: {id: 'table-of-contents'} -->
# Table of Contents
* Searching algorithms
	* Naive string search
	* Rabin-Karp
	* Knuth-Morris-Pratt
	* Aho-Corasick
	* Suffix trees/arrays

<!-- section start -->

<!-- attr: {class: 'slide-section'} -->
# Searching algorithms
## Subtitle

<!-- section start -->

<!-- attr: {} -->
# Naive search
* Test for match at every possible position
	* Simple but inefficient
	* Quadratic in time (worstcase)

<!-- section start -->

<!-- attr: {} -->
# Rabin-Karp
* Uses rolling hash
	* Linear in time
		* Quadratic if you check for collisions
* Capable of multiple pattern search

<!-- attr: {showInPresentation: true} -->
<!-- # Rabin-Karp -->
* The hash of the pattern is computed
* The hashes of each text substring of the same length is computed
	* By rolling the hash
	* Linear in time
* Hash values are numbers
	* Simple to compare

<!-- section start -->

<!-- attr: {hasScriptWrapper: true} -->
# Knuth-Morris-Pratt
* Makes use of previous match info
	* "Partial match" table is precomputed
		* Linear in time
	* Unneeded checks are skipped
	* Linear in time

<img src="imgs/kmpexample.jpg" width="40%" style="float:right">

<!-- section start -->

<!-- attr: {hasScriptWrapper: true} -->
# Aho-Corasick
* Like KMP, but for multiple patters
	* "Partial match" prefix tree is precomputed
	* Each occurrence of each pattern is found
	* Linear in time
		* There can be quadratic number of occurrences

<img src="imgs/Ahocorasick.png" width="30%" style="float:right">

<!-- section start -->

<!-- attr: {} -->
# Suffix trees
* Compressed trie of prefixes
	* Linear in time

<img src="imgs/Suffix_tree.png" width="30%" style="float:right">

<!-- section start -->

<!-- attr: {class: 'slide-questions', id: 'questions'}  -->
# Algorithms on Strings
## Questions
