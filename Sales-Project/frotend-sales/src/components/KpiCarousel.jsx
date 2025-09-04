// import { useRef } from "react";
// import { ChevronLeft, ChevronRight } from "lucide-react";
// import KpiCard from "./KpiCard";

// export default function Slider({ items = [], selected, setSelected }) {
//   const sliderRef = useRef(null);

//   const scroll = (offset) => {
//     if (sliderRef.current) {
//       sliderRef.current.scrollBy({ left: offset, behavior: "smooth" });
//     }
//   };

//   return (
//     <div className="relative">
//       {/* Arrows */}
//       <button
//         onClick={() => scroll(-250)}
//         className="absolute left-0 top-1/2 -translate-y-1/2 z-10 p-2 bg-white dark:bg-zinc-800 rounded-full shadow-md"
//       >
//         <ChevronLeft />
//       </button>
//       <button
//         onClick={() => scroll(250)}
//         className="absolute right-0 top-1/2 -translate-y-1/2 z-10 p-2 bg-white dark:bg-zinc-800 rounded-full shadow-md"
//       >
//         <ChevronRight />
//       </button>

//       {/* Scrollable Container */}
//       <div
//         ref={sliderRef}
//         className="flex gap-4 overflow-x-auto scroll-smooth no-scrollbar px-8 pb-2"
//       >
//         {items.map((item, index) => (
//           <KpiCard
//             key={index}
//             {...item}
//             isActive={selected === index}
//             onClick={() => setSelected(index)}
//           />
//         ))}
//       </div>
//     </div>
//   );
// }

import { useKeenSlider } from "keen-slider/react";
import "keen-slider/keen-slider.min.css";
import { useState, useEffect, useRef } from "react";
import KpiCard from "./KpiCard";

export default function KpiCarousel({ kpis, onSelect }) {
  const [currentSlide, setCurrentSlide] = useState(0);

  const timer = useRef();

  const [sliderRef, instanceRef] = useKeenSlider({
    loop: true, // ✅ Loop back to start when list ends
    slideChanged(slider) {
      setCurrentSlide(slider.track.details.rel);
      onSelect?.(slider.track.details.rel);

      // 🔁 Restart autoplay timer on slide change
      clearInterval(timer.current);
      timer.current = setInterval(() => {
        instanceRef.current?.next();
      }, 3000);
    },
    created() {
      // ▶️ Start autoplay when slider is initialized
      timer.current = setInterval(() => {
        instanceRef.current?.next();
      }, 3000);
    },
    destroyed() {
      // 🧼 Clear autoplay when slider is destroyed
      clearInterval(timer.current);
    },
    slides: {
      perView: 1, // ✅ Only one KPI card at a time
    },
  });

  const next = () => instanceRef.current?.next();
  const prev = () => instanceRef.current?.prev();

  return (
    <div className="w-full flex justify-center h-fit text-[#f8fafc]">
      <div className="relative w-[300px] overflow-visible">
        {/* Carousel */}
        <div ref={sliderRef} className="keen-slider overflow-visible">
          {kpis.map((kpi, index) => (
            <div
              key={index}
              className="keen-slider__slide flex justify-center py-4"
            >
              <KpiCard
                {...kpi}
                isActive={currentSlide === index}
                onClick={() => {}}
              />
            </div>
          ))}
        </div>

        {/* Navigation Arrows */}
        <button
          onClick={prev}
          className="absolute top-1/2 -left-10 transform -translate-y-1/2 bg-white/5 backdrop-blur-md shadow-lg px-2 py-1 rounded-l-3xl rounded-r-md hover:ring-2 hover:ring-[#60a5fa] text-[#f8fafc]"
        >
          ←
        </button>
        <button
          onClick={next}
          className="absolute top-1/2 -right-10 transform -translate-y-1/2 bg-white/5 backdrop-blur-md shadow-lg px-2 py-1 rounded-r-3xl rounded-l-md hover:ring-2 hover:ring-[#60a5fa] text-[#f8fafc]"
        >
          →
        </button>
      </div>
    </div>
  );
}
