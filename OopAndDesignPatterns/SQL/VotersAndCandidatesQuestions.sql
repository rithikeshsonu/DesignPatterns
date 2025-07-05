SELECT * FROM Constituencies
SELECT * FROM Candidates
SELECT * FROM Voters

--1. List all candidates and their constituency names.
SELECT cand.Name, cons.Name
FROM 
Candidates cand 
JOIN Constituencies cons on cand.constituencyId = cons.constituencyid

--2. How many voters voted?
SELECT COUNT(VoterId)
FROM Voters WHERE VotedCandidateID IS NOT NULL

--3. Count votes received by each candidate.
SELECT c.Name, COUNT(v.voterId) FROM Candidates c 
JOIN Voters v on c.CandidateID = v.VotedCandidateID GROUP BY c.Name

--4. Find the winner (most votes) in each constituency.
With 
VoteCount AS(
	SELECT c.CandidateID, c.Name, c.ConstituencyID, COUNT(v.voterId) as Votes
	FROM Candidates c
	JOIN Voters v ON c.CandidateID = v.VotedCandidateID
	GROUP BY c.CandidateID, c.Name, c.ConstituencyID
),
Ranked AS(
	SELECT *, RANK() OVER (PARTITION BY ConstituencyId ORDER BY 
	Votes DESC) AS rnk FROM VoteCount
)
SELECT * FROM Ranked WHERE rnk = 1

--5. List all voters who have not voted.
SELECT * FROM Voters
WHERE VotedCandidateID IS NULL;

--6. List parties and number of candidates for each.

SELECT Party, COUNT(Party) as Count FROM Candidates GROUP BY Party

--7. List constituencies with more than one candidate.

SELECT ConstituencyId, COUNT(ConstituencyId) as canCount
FROM Candidates
GROUP BY ConstituencyId
having count(ConstituencyId) > 1

--8. Find the gender distribution among voters.

SELECT Gender, COUNT(*) As VoterCount
FROM Voters GROUP BY Gender

--9. Who received zero votes?

SELECT c.Name
FROM Candidates c
JOIN Voters v ON c.CandidateID = v.VotedCandidateID
GROUP BY c.Name 
HAVING COUNT(v.voterID) = 0;

--10. List voters with their voted candidate’s name and party.

SELECT v.Name, c.Name, c.Party
FROM Voters v 
LEFT JOIN Candidates c on v.VotedCandidateID = c.CandidateID --Left JOIN TO GET NULLS As WELL

--11. Average age of voters per constituency.
SELECT cs.Name, AVG(v.Age) as AvgAge
FROM Voters v 
LEFT JOIN Candidates c on v.VotedCandidateID = c.CandidateID
LEFT JOIN Constituencies cs ON c.ConstituencyID = cs.ConstituencyID
GROUP BY cs.Name

SELECT * FROM voters
SELECT* FROM Candidates
SELECT * FROM Constituencies