import { useEffect, useRef, useState } from "react";

const GlobalMarqueeTable = ({
  title,
  data,
  columns,
  className = "",
  speed = 50,
}) => {
  const containerRef = useRef(null);
  const pausedRef = useRef(false); // <- persist pause across renders
  const [isPaused, setIsPaused] = useState(false);

  // keep pausedRef in sync with UI state, but don't restart the interval
  useEffect(() => {
    pausedRef.current = isPaused;
  }, [isPaused]);

  // auto-scroll loop (doesn't depend on isPaused to avoid reset)
  useEffect(() => {
    const container = containerRef.current;
    if (!container) return;

    // if content fits, don't start the loop
    const fits = container.scrollHeight <= container.clientHeight;
    if (fits) return;

    const step = () => {
      if (!pausedRef.current) {
        container.scrollTop += 1;

        // seamless loop: when we pass half (since we duplicate data), wrap back
        const half = container.scrollHeight / 2;
        if (container.scrollTop >= half) {
          container.scrollTop -= half;
        }
      }
    };

    const id = setInterval(step, speed);
    return () => clearInterval(id);
  }, [speed, data.length]); // re-evaluate only when speed or data size changes

  // reset position when data changes (optional)
  useEffect(() => {
    const container = containerRef.current;
    if (container) container.scrollTop = 0;
  }, [data]);

  // duplicate rows for infinite scroll
  const scrollingData = data.length ? [...data, ...data] : [];

  return (
    <div
      className={`p-6 rounded-xl bg-[#252538] border border-[#38384a] hover:border-[#8a4fff]/50 transition-colors duration-300 ${className}`}
    >
      {title && (
        <h3 className="text-lg font-semibold text-[#BEB7DF] mb-4">{title}</h3>
      )}

      <div
        ref={containerRef}
        className="overflow-y-auto h-80 relative"
        onMouseEnter={() => setIsPaused(true)}
        onMouseLeave={() => setIsPaused(false)}
      >
        <table className="w-full min-w-[600px]">
          <thead className="sticky top-0 bg-[#252538] z-10">
            <tr className="border-b border-[#38384a]">
              {columns.map((column) => (
                <th
                  key={column.field}
                  className={`px-4 py-3 text-sm font-medium text-gray-300 ${column.style}`}
                >
                  {column.header}
                </th>
              ))}
            </tr>
          </thead>
          <tbody>
            {scrollingData.map((row, rowIndex) => (
              <tr
                key={rowIndex}
                className={`${
                  rowIndex % 2 === 0 ? "bg-[#252538]" : "bg-[#2d2d42]"
                } hover:bg-[#38384a] transition-colors`}
              >
                {columns.map((column) => (
                  <td
                    key={column.field}
                    className={`px-4 py-3 text-sm text-[#BEB7DF] ${column.style}`}
                  >
                    <span className="whitespace-nowrap">
                      {row[column.field]}
                    </span>
                  </td>
                ))}
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
};

export default GlobalMarqueeTable;
