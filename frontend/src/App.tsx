import React from 'react';
import './App.css';
import Header from './Header';
import BowlerList from './BowlerInfo/BowlersList';

function App() {
  return (
    <div className="App">
      <Header
        title="Bowlers Roster: Marlins vs. Sharks"
        description="Discover the complete lineup of bowlers for both the Marlins and Sharks teams. From seasoned veterans to rising stars, explore the talent pool ready to strike at every frame."
      />
      <BowlerList />
    </div>
  );
}

export default App;
