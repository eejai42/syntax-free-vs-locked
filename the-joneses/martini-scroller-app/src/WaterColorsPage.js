import React, { useState } from 'react';
import YCombiner from './YCombiner';

const WaterColorsPage = () => {
    const [outputColor1, setOutputColor1] = useState(null);
    const [outputColor2, setOutputColor2] = useState(null);

    return (
        <div>
            <YCombiner
                onMixedColorChange={setOutputColor1}
            />
            this is a div
            <YCombiner
                externalColor1={outputColor1}
                onMixedColorChange={setOutputColor2}
            />
            {/* More YCombiner components can be added as needed, linking outputColor2 or other states similarly */}
        </div>
    );
};


export default WaterColorsPage;