# PowerPomPom
崩壊スターレイルPC版のFPS上限を60FPSから120FPSに解除するGUI / GUI software to unlock 60 fps cap up to 120 on Honkai Star Rail

## ダウンロード
- Releaseから[最新のZIPファイル](https://github.com/rexent-gx/PowerPomPom/releases/latest/download/PowerPomPom.zip)をダウンロードして任意のディレクトリに解凍してください。

## 使い方
1. `PowerPomPom.exe`をダブルクリックして起動します。
   - エラーが出た場合、一度崩壊スターレイルを起動してから再試行してみてください。
1. 画面左側のFPSスライダーを操作することで上限FPSを変更できます。
   - 設定した値は保持されるため、一度設定した後は本プログラムを起動する必要はありません。

## 注意事項
- グラフィック設定のレジストリ内容を書き換えています。
- 本プログラムの使用に伴ういかなる事象についての責任は負いかねますので、ご利用は自己責任でお願いします。

## FAQ
### Q. なんで120までしか出ないの？
A. レジストリ編集で120以上にも設定できるのですが、対応していないのかゲーム起動時に60FPSにリセットされてしまうようです。
 
### Q. [PowerPaimon](https://github.com/rexent-gx/PowerPaimon)みたいにプロセスメモリをオーバーライドすればいいのでは？
A. メモリのアドレスが流石に原神とは異なるのか、PowerPaimonのソースを多少変更した程度では動作しませんでした。メモリサーチ等すれば行けるのかもしれませんが、素人なのであんまり触らないでおきます。将来的に手法が確立したら240とかにも対応したいです。

---

## EN
## Download
- Download [latest zip file](https://github.com/rexent-gx/PowerPomPom/releases/latest/download/PowerPomPom.zip) from Releases.

## How to Use
1. Launch `PowerPomPom.exe`.
   - If an error occurred while launching, please launch the HSR game first and try again.
1. Control the FPS Slider to change the max fps cap.
   - Max fps value will save to the registry automatically, so you don't have to launch this software again.
