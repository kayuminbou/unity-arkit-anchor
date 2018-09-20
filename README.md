# unity-arkit-anchor
## 概要
ARKitを用いて認識したアイコンの周りにオブジェクトやUIを表示させるアプリです。  

<p align="center">
  <img src="demo.gif" width="266">
</p>

## 開発環境
- Unity v2018.2.3f1
- Apple Xcode 9.4.1
- iPhone 7
- Apple iOS 12.0  

## インストール方法

### 1. git cloneでローカルへ持ってきたら、Asset/week3をUnityで開く

### 2. iOS端末にビルドする
私のアイコンをカメラを向けるとボタンが出現し、タップすることで私のGithubページへジャンプする...はずです。  
読み込むアイコン(ARマーカーと言います)や出現させるImageAnchorを適当に変更してやることで、自分なりのカスタマイズができる...はずです。  
ただしXcodeでのビルド時には下図のように自身のiOS端末に合わせた設定にしておかないと、ビルドには成功してもアプリが正常に動かない可能性があります。  

<p align="center">
  <img src="xcodeimage.png">
</p>

## 作成手順
### 1. 読み込むARマーカーをインポートする
1. Assets/UnityARKitPlugin/Examples/ARKit1.5/UnityARImageAnchor/ReferenceImages配下にARマーカーとなる画像をインポートします。
### 2.ProjectのCreateからARReferenceImageを作成し、Inspecterに必要な情報を入力する
1. ImageNameに画像の名前
1. ImageTextureに先ほど追加した画像
1. PhysicalSizeに画像のサイズ(単位はメートル)
### 3. Assets/UnityARKitPlugin/Examples/ARKit1.5/UnityARImageAnchor/ARImagesSet_UnityLogoのReferenceImageを入力する
1. Sizeに認識する画像の数
1. Elementに呼び出したいARReferenceImage
### 4. HierarchyからCreateEmptyを作成し(GenerateImageAnchorとリネーム)、GenerateImageAnchorスクリプトをadd componentする
### 5. 認識した画像の上に出現させたいPrefabを作成する
Prefabにするオブジェクトは3dオブジェクトでもUIでも可能ですが、注意しておきたいのはARマーカーは地面にあることが想定されている？ため、物体が認識した画像の上に並列ではなく垂直に表示されてしまうことです。  
これを避けるために、Prefabにしたいオブジェクトの親として空オブジェクトを作成し、子となったオブジェクトのRotationをX=90にしてやるなどすることで、表示させる向きを調整することが必要となります。
### 6. GenerateImageAnchorにInspectorを入力する
1. ReferenceImageに先ほど作成したARReferenceImage
1. PrefabToGenerateに先ほど作成したPrefab

これでビルドすれば大丈夫なはずです。

