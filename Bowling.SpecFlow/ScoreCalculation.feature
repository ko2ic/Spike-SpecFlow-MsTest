﻿機能: ボウリングスコア計算
  トータススコアを計算するシステムがほしい
  
シナリオ:ガーター 
  前提 新しいゲームを始める
  もし すべてガーター
  ならば 次のスコアになります:0
  
シナリオ: 初心者
  前提 新しいゲームを始める
  もし 一投目2本、二投目7本倒した
  かつ 一投目3本、二投目4本倒した
  かつ 8フレームすべてで、一投目1本、二投目1本倒した
  ならば 次のスコアになります:32
  
シナリオ: 違う初心者
  前提 新しいゲームを始める
  もし 次のピンを倒した:	2,7,3,4,1,1,5,1,1,1,1,1,1,1,1,1,1,1,5,1
  ならば 次のスコアになります:40
  
シナリオ: すべてストライク 
  前提 新しいゲームを始める
  もし すべてストライク
  ならば 次のスコアになります:300
  
シナリオ: 最初だけスペア 
   前提 新しいゲームを始める
   もし 次のピンを倒した: 2,8,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1
   ならば 次のスコアになります:29
   
シナリオ: すべてスペア 
  前提 新しいゲームを始める
  もし 10フレームすべてで、一投目1本、二投目9本倒した
  かつ 1本倒した
  ならば 次のスコアになります:110
