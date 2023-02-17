const bubbleInformation = [
  {
    header: "TRẺ TRUNG NĂNG ĐỘNG",
    content:
      "Các bạn gia sư là sinh viên đến từ ngôi trường đại học FPT của chúng ta",
  },
  {
    header: "THẤU HIỂU",
    content:
      "đã và đang theo học tại trường, các gia sư có thể thấu hiểu được các vấn đề của sinh viên",
  },
  {
    header: "ỨNG DỤNG HIỆU QUẢ ",
    content:
      "với kinh nghiệm theo học tại trường, đưa ra các bài giảng và lời khuyên học tập hiệu quả",
  },
  {
    header: "Đúng người, đúng môn",
    content:
      "tập trung dạy các môn đang nằm trong giáo trình đại học FPT đang hiện có ",
  },
  {
    header: "TIN CẬY và an toàn",
    content:
      "Là các sinh viên cùng trường, dễ dàng kiểm duyệt và giải quyết các vấn đề phát sinh",
  },
  {
    header: "Đúng người, đúng môn",
    content:
      "tập trung dạy các môn đang nằm trong giáo trình đại học fpt hiện có",
  },
];

function transformBubble(index, header, content, defaultNode) {
  defaultNode.querySelector(".index-number").innerHTML = index;
  defaultNode.querySelector(".bubble-header").innerHTML = header;
  defaultNode.querySelector(".bubble-content").innerHTML = content;
  defaultNode.classList.add(`bubble-information-${index}`);
  defaultNode.classList.remove(`hidden`);
}

function appendBubbleNode() {
  let bubbleDefault = document.getElementById("default-bubble");

  bubbleInformation.forEach((bubble, index) => {
    let newBubble = bubbleDefault.cloneNode(true);
    transformBubble(
      String(index + 1),
      bubble.header,
      bubble.content,
      newBubble
    );
    document.getElementById("suitable-tutors").appendChild(newBubble);
  });
}

appendBubbleNode();
