use SQLPractice
GO
CREATE TABLE Constituencies (
    ConstituencyID INT PRIMARY KEY,
    Name VARCHAR(100)
);
GO
CREATE TABLE Candidates (
    CandidateID INT PRIMARY KEY,
    Name VARCHAR(100),
    Party VARCHAR(50),
    ConstituencyID INT,
    FOREIGN KEY (ConstituencyID) REFERENCES Constituencies(ConstituencyID)
);
GO
CREATE TABLE Voters (
    VoterID INT PRIMARY KEY,
    Name VARCHAR(100),
    Age INT,
    Gender CHAR(1),
    VotedCandidateID INT NULL,
    FOREIGN KEY (VotedCandidateID) REFERENCES Candidates(CandidateID)
);
GO
-- Constituencies
INSERT INTO Constituencies VALUES
(1, 'Northville'), (2, 'Southville'), (3, 'Easton');
GO
-- Candidates
INSERT INTO Candidates VALUES
(1, 'Alice', 'Progressive', 1),
(2, 'Bob', 'Conservative', 1),
(3, 'Charlie', 'Liberal', 2),
(4, 'Diana', 'Progressive', 2),
(5, 'Eve', 'Independent', 3);
GO
-- Voters
INSERT INTO Voters VALUES
(101, 'John', 28, 'M', 1),
(102, 'Sarah', 34, 'F', 2),
(103, 'Mark', 40, 'M', 3),
(104, 'Lily', 22, 'F', 3),
(105, 'Tom', 31, 'M', 4),
(106, 'Nina', 25, 'F', 2),
(107, 'Oscar', 29, 'M', NULL),
(108, 'Emma', 38, 'F', 4),
(109, 'Jake', 33, 'M', 5),
(110, 'Sophia', 27, 'F', NULL);
