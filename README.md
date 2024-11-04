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
- 設定画面の表示について: 本プログラムで設定したFPS上限は、ゲーム内の設定画面には反映されません。例えば、ゲーム内でFPS上限が30と表示されている場合でも、実際にはPowerPomPomで設定した上限（例：120FPS）が反映されています。実際のFPSを確認する際は、グラフィックボードのFPSカウンターなどをご利用ください。

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
1. Launch `PowerPomPom.exe`, and extract the archive.
   - If an error occurred while launching, please launch the HSR game first and try again.
1. Control the FPS Slider to change the max fps cap.
   - Max fps value will save to the registry automatically, so you don't have to launch this software again.

## Notes
- This software modifies the graphics settings in the Windows registry.
- The developers are not responsible for any issues that may arise from the use of this software. Please use it at your own risk.
- Display of FPS Cap in the Settings: The FPS cap set by PowerPomPom is not reflected in the in-game settings menu. For example, even if the game displays the cap as 30 FPS, the actual limit set by PowerPomPom (e.g., 120 FPS) will be applied. To verify the actual FPS, please use a graphics card FPS counter or similar tools.

## FAQ
### Q. Why is the limit capped at 120 FPS?
A. While the registry can be modified to go beyond 120 FPS, it seems the game resets to 60 FPS upon launch, likely because it doesn't support higher values.

### Q. Why not override process memory like PowerPaimon?
A. The memory addresses for Honkai Star Rail appear to differ significantly from those in Genshin Impact. Modifying the PowerPaimon source code only slightly was not enough to make it work. It might be possible with extensive memory searching, but as I'm not an expert, I'm avoiding it for now. If I can figure out a reliable method in the future, I'd like to extend the cap to 240 FPS or beyond.
