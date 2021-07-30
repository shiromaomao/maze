Shader "Water"
{

    //コピペ 色付き屈折Shader
    Properties
    {
        _DistortionTex("Distortion Texture(RG)", 2D) = "grey" {}
        _DistortionPower("Distortion Power", Range(0, 1)) = 0
        _Color("WaterColor", Color) = (0,0,0,0)
    }

        SubShader
        {
            Tags {"Queue" = "Transparent" "RenderType" = "Transparent" }

            Cull Back
            ZWrite On
            ZTest LEqual
            ColorMask RGB

            GrabPass { "_GrabPassTexture" }

            Pass {

                CGPROGRAM
               #pragma vertex vert
               #pragma fragment frag

               #include "UnityCG.cginc"

                struct appdata {
                    half4 vertex  : POSITION;
                    half4 texcoord  : TEXCOORD0;
                };

                struct v2f {
                    half4 vertex  : SV_POSITION;
                    half2 uv  : TEXCOORD0;
                    half4 grabPos : TEXCOORD1;
                };

                sampler2D _DistortionTex;
                half4 _DistortionTex_ST;
                sampler2D _GrabPassTexture;
                half _DistortionPower;
                half4 _Color;

                v2f vert(appdata v)
                {
                    v2f o = (v2f)0;

                    o.vertex = UnityObjectToClipPos(v.vertex);
                    o.uv = TRANSFORM_TEX(v.texcoord, _DistortionTex);
                    o.grabPos = ComputeGrabScreenPos(o.vertex);

                    return o;
                }

                fixed4 frag(v2f i) : SV_Target
                {
                    // w除算
                    half2 uv = half2(i.grabPos.x / i.grabPos.w, i.grabPos.y / i.grabPos.w);

                    // Distortionの値に応じてサンプリングするUVをずらす
                    half2 distortion = UnpackNormal(tex2D(_DistortionTex, i.uv + _Time.x * 0.1f)).rg;
                    distortion *= _DistortionPower;

                    uv += distortion;
                    return tex2D(_GrabPassTexture, uv) * _Color;
                }
                ENDCG
            }
        }
}

    /*Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0
    }
    SubShader
    {
        Tags { "RenderType" = "Transparent" "Queue" = "Transparent"}
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        half _Glossiness;
        half _Metallic;
        fixed4 _Color;

        // Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
        // See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
        // #pragma instancing_options assumeuniformscaling
        UNITY_INSTANCING_BUFFER_START(Props)
            // put more per-instance properties here
        UNITY_INSTANCING_BUFFER_END(Props)

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            // Albedo comes from a texture tinted by color
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
            o.Albedo = fixed4(63,232,253,150);
            // Metallic and smoothness come from slider variables
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"*/

    //コピペ
    /*Properties{
        _Color("Color", Color) = (1,1,1,1)
        _MainTex("Albedo (RGB)", 2D) = "white" {}
    }

        SubShader{
            Tags { "RenderType" = "Transparent" "Queue" = "Transparent"}
            LOD 200

            Pass{
              ZWrite ON
              ColorMask 0
            }

            CGPROGRAM
            #pragma surface surf Standard fullforwardshadows alpha:fade
            #pragma target 3.0

            sampler2D _MainTex;

            struct Input {
                float2 uv_MainTex;
            };

            fixed4 _Color;

            void surf(Input IN, inout SurfaceOutputStandard o)
            {
                fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
                o.Albedo = c.rgb;
                o.Metallic = 0;
                o.Smoothness = 0;
                o.Alpha = c.a;
            }
            ENDCG
    }
        FallBack "Diffuse"
}*/