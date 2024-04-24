import React, { useState } from 'react';
import YCombiner from './YCombiner';

const WaterColorsPage = () => {
    const [outputColor1, setOutputColor1] = useState(null); // Holds the output of the first YCombiner

    return (
        <div>
            <YCombiner onMixedColorChange={setOutputColor1} />
            <div style={{ display: 'flex', justifyContent: 'space-around' }}>
                <YCombiner externalColor2={outputColor1} onMixedColorChange={() => {}} />
                <YCombiner externalColor1={outputColor1} onMixedColorChange={() => {}} />
            </div>
        </div>
    );
};

export default WaterColorsPage;
