import React from 'react';

// Mock data for demonstration, replace with your actual prop data
const mockChapters = [
  {
    name: "Meet the Joneses",
    hint: "The Family",
    statement: "The Joneses, Alice and Bob, have one son Charlie, who owns a white, fluffy dog named Dingo.",
    id: "meet-the-joneses",
    image: "glasses/meet-the-joneses.png",
    intro: "Today I'd like to introduce you to the notion of Syntax-Locking, and how, like paper-based businesses in the 80's and early 90's, if your business decisions are still syntax-locked, then even the *very* short story will likely ring true for you.",
    "syntax-locked-intro": "Specifically - if the details of your projects are still locked in syntax, like this one sentence summary of the Jones Family, then you're likely to be experiencing the same problems that we are about to explore, as the Jones family grows, changes & evolves over time. The reason for this pain (as you will hopefully see) is that syntax-locking is an expensive and generally inefficient way to record and communicate the details of even a simple story like this. Let's explore what happens when we avoid this pain by moving away from syntax-locking, and towards a world where the key elements of your business and projects are captured free from syntax.",
    "syntax-free-intro": "Here, for example, you'll notice that the syntax-free Mirror of the Jones family on the right, contains just 1 Charlie - so it's charlie counter is still 1.  All of the counters are actually still 1.  And they will remain 1 for as long as they are each involved in the story.  Because there's just 1 Charlie.  Always, just 1 Charlie.",
    mantra: "So the specific cause of the pain from syntax-locking is the fact that the Charlie counter on the left is already at #charlieCounter#, and counting... and it will just keep going up, unrelentingly - over time, especially as the project grows in size and complexity.",
    keywords: ["charlie", "alice", "bob"],
    staleKeywords: [],
    visibleLanguages: ["English", "Code"],
  }
  // Add more chapters as necessary
];

const ScriptPage = ({ chapters = mockChapters }) => {
  return (
    <div>
      {chapters.map((chapter, index) => (
        <div key={chapter.id || index} style={{ marginBottom: '2rem' }}>
          <h2>{chapter.name}</h2>
          <p><strong>Intro:</strong> {chapter.intro}</p>
          <p><strong>Syntax-Locked Intro:</strong> {chapter['syntax-locked-intro']}</p>
          <p><strong>Syntax-Free Intro:</strong> {chapter['syntax-free-intro']}</p>
          <p><strong>Mantra:</strong> {chapter.mantra}</p>
          <p><strong>Keywords:</strong> {chapter.keywords.join(', ')}</p>
          <p><strong>Visible Languages:</strong> {chapter.visibleLanguages.join(', ')}</p>
        </div>
      ))}
    </div>
  );
};

export default ScriptPage;
