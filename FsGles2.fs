module FsGles2

#nowarn "9"
#nowarn "1182"

open System
open System.Runtime.InteropServices

type GLenum = 
    | GL_DEPTH_BUFFER_BIT               = 0x00000100
    | GL_STENCIL_BUFFER_BIT             = 0x00000400
    | GL_COLOR_BUFFER_BIT               = 0x00004000
    | GL_FALSE                          = 0
    | GL_TRUE                           = 1
    | GL_POINTS                         = 0x0000
    | GL_LINES                          = 0x0001
    | GL_LINE_LOOP                      = 0x0002
    | GL_LINE_STRIP                     = 0x0003
    | GL_TRIANGLES                      = 0x0004
    | GL_TRIANGLE_STRIP                 = 0x0005
    | GL_TRIANGLE_FAN                   = 0x0006
    | GL_ZERO                           = 0
    | GL_ONE                            = 1
    | GL_SRC_COLOR                      = 0x0300
    | GL_ONE_MINUS_SRC_COLOR            = 0x0301
    | GL_SRC_ALPHA                      = 0x0302
    | GL_ONE_MINUS_SRC_ALPHA            = 0x0303
    | GL_DST_ALPHA                      = 0x0304
    | GL_ONE_MINUS_DST_ALPHA            = 0x0305
    | GL_DST_COLOR                      = 0x0306
    | GL_ONE_MINUS_DST_COLOR            = 0x0307
    | GL_SRC_ALPHA_SATURATE             = 0x0308
    | GL_FUNC_ADD                       = 0x8006
    | GL_BLEND_EQUATION                 = 0x8009
    | GL_BLEND_EQUATION_RGB             = 0x8009
    | GL_BLEND_EQUATION_ALPHA           = 0x883D
    | GL_FUNC_SUBTRACT                  = 0x800A
    | GL_FUNC_REVERSE_SUBTRACT          = 0x800B
    | GL_BLEND_DST_RGB                  = 0x80C8
    | GL_BLEND_SRC_RGB                  = 0x80C9
    | GL_BLEND_DST_ALPHA                = 0x80CA
    | GL_BLEND_SRC_ALPHA                = 0x80CB
    | GL_CONSTANT_COLOR                 = 0x8001
    | GL_ONE_MINUS_CONSTANT_COLOR       = 0x8002
    | GL_CONSTANT_ALPHA                 = 0x8003
    | GL_ONE_MINUS_CONSTANT_ALPHA       = 0x8004
    | GL_BLEND_COLOR                    = 0x8005
    | GL_ARRAY_BUFFER                   = 0x8892
    | GL_ELEMENT_ARRAY_BUFFER           = 0x8893
    | GL_ARRAY_BUFFER_BINDING           = 0x8894
    | GL_ELEMENT_ARRAY_BUFFER_BINDING   = 0x8895
    | GL_STREAM_DRAW                    = 0x88E0
    | GL_STATIC_DRAW                    = 0x88E4
    | GL_DYNAMIC_DRAW                   = 0x88E8
    | GL_BUFFER_SIZE                    = 0x8764
    | GL_BUFFER_USAGE                   = 0x8765
    | GL_CURRENT_VERTEX_ATTRIB          = 0x8626
    | GL_FRONT                          = 0x0404
    | GL_BACK                           = 0x0405
    | GL_FRONT_AND_BACK                 = 0x0408
    | GL_TEXTURE_2D                     = 0x0DE1
    | GL_CULL_FACE                      = 0x0B44
    | GL_BLEND                          = 0x0BE2
    | GL_DITHER                         = 0x0BD0
    | GL_STENCIL_TEST                   = 0x0B90
    | GL_DEPTH_TEST                     = 0x0B71
    | GL_SCISSOR_TEST                   = 0x0C11
    | GL_POLYGON_OFFSET_FILL            = 0x8037
    | GL_SAMPLE_ALPHA_TO_COVERAGE       = 0x809E
    | GL_SAMPLE_COVERAGE                = 0x80A0
    | GL_NO_ERROR                       = 0
    | GL_INVALID_ENUM                   = 0x0500
    | GL_INVALID_VALUE                  = 0x0501
    | GL_INVALID_OPERATION              = 0x0502
    | GL_OUT_OF_MEMORY                  = 0x0505
    | GL_CW                             = 0x0900
    | GL_CCW                            = 0x0901
    | GL_LINE_WIDTH                     = 0x0B21
    | GL_ALIASED_POINT_SIZE_RANGE       = 0x846D
    | GL_ALIASED_LINE_WIDTH_RANGE       = 0x846E
    | GL_CULL_FACE_MODE                 = 0x0B45
    | GL_FRONT_FACE                     = 0x0B46
    | GL_DEPTH_RANGE                    = 0x0B70
    | GL_DEPTH_WRITEMASK                = 0x0B72
    | GL_DEPTH_CLEAR_VALUE              = 0x0B73
    | GL_DEPTH_FUNC                     = 0x0B74
    | GL_STENCIL_CLEAR_VALUE            = 0x0B91
    | GL_STENCIL_FUNC                   = 0x0B92
    | GL_STENCIL_FAIL                   = 0x0B94
    | GL_STENCIL_PASS_DEPTH_FAIL        = 0x0B95
    | GL_STENCIL_PASS_DEPTH_PASS        = 0x0B96
    | GL_STENCIL_REF                    = 0x0B97
    | GL_STENCIL_VALUE_MASK             = 0x0B93
    | GL_STENCIL_WRITEMASK              = 0x0B98
    | GL_STENCIL_BACK_FUNC              = 0x8800
    | GL_STENCIL_BACK_FAIL              = 0x8801
    | GL_STENCIL_BACK_PASS_DEPTH_FAIL   = 0x8802
    | GL_STENCIL_BACK_PASS_DEPTH_PASS   = 0x8803
    | GL_STENCIL_BACK_REF               = 0x8CA3
    | GL_STENCIL_BACK_VALUE_MASK        = 0x8CA4
    | GL_STENCIL_BACK_WRITEMASK         = 0x8CA5
    | GL_VIEWPORT                       = 0x0BA2
    | GL_SCISSOR_BOX                    = 0x0C10
    | GL_COLOR_CLEAR_VALUE              = 0x0C22
    | GL_COLOR_WRITEMASK                = 0x0C23
    | GL_UNPACK_ALIGNMENT               = 0x0CF5
    | GL_PACK_ALIGNMENT                 = 0x0D05
    | GL_MAX_TEXTURE_SIZE               = 0x0D33
    | GL_MAX_VIEWPORT_DIMS              = 0x0D3A
    | GL_SUBPIXEL_BITS                  = 0x0D50
    | GL_RED_BITS                       = 0x0D52
    | GL_GREEN_BITS                     = 0x0D53
    | GL_BLUE_BITS                      = 0x0D54
    | GL_ALPHA_BITS                     = 0x0D55
    | GL_DEPTH_BITS                     = 0x0D56
    | GL_STENCIL_BITS                   = 0x0D57
    | GL_POLYGON_OFFSET_UNITS           = 0x2A00
    | GL_POLYGON_OFFSET_FACTOR          = 0x8038
    | GL_TEXTURE_BINDING_2D             = 0x8069
    | GL_SAMPLE_BUFFERS                 = 0x80A8
    | GL_SAMPLES                        = 0x80A9
    | GL_SAMPLE_COVERAGE_VALUE          = 0x80AA
    | GL_SAMPLE_COVERAGE_INVERT         = 0x80AB
    | GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2
    | GL_COMPRESSED_TEXTURE_FORMATS     = 0x86A3
    | GL_DONT_CARE                      = 0x1100
    | GL_FASTEST                        = 0x1101
    | GL_NICEST                         = 0x1102
    | GL_GENERATE_MIPMAP_HINT           = 0x8192
    | GL_BYTE                           = 0x1400
    | GL_UNSIGNED_BYTE                  = 0x1401
    | GL_SHORT                          = 0x1402
    | GL_UNSIGNED_SHORT                 = 0x1403
    | GL_INT                            = 0x1404
    | GL_UNSIGNED_INT                   = 0x1405
    | GL_FLOAT                          = 0x1406
    | GL_FIXED                          = 0x140C
    | GL_DEPTH_COMPONENT                = 0x1902
    | GL_ALPHA                          = 0x1906
    | GL_RGB                            = 0x1907
    | GL_RGBA                           = 0x1908
    | GL_LUMINANCE                      = 0x1909
    | GL_LUMINANCE_ALPHA                = 0x190A
    | GL_UNSIGNED_SHORT_4_4_4_4         = 0x8033
    | GL_UNSIGNED_SHORT_5_5_5_1         = 0x8034
    | GL_UNSIGNED_SHORT_5_6_5           = 0x8363
    | GL_FRAGMENT_SHADER                = 0x8B30
    | GL_VERTEX_SHADER                  = 0x8B31
    | GL_MAX_VERTEX_ATTRIBS             = 0x8869
    | GL_MAX_VERTEX_UNIFORM_VECTORS     = 0x8DFB
    | GL_MAX_VARYING_VECTORS            = 0x8DFC
    | GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D
    | GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C
    | GL_MAX_TEXTURE_IMAGE_UNITS        = 0x8872
    | GL_MAX_FRAGMENT_UNIFORM_VECTORS   = 0x8DFD
    | GL_SHADER_TYPE                    = 0x8B4F
    | GL_DELETE_STATUS                  = 0x8B80
    | GL_LINK_STATUS                    = 0x8B82
    | GL_VALIDATE_STATUS                = 0x8B83
    | GL_ATTACHED_SHADERS               = 0x8B85
    | GL_ACTIVE_UNIFORMS                = 0x8B86
    | GL_ACTIVE_UNIFORM_MAX_LENGTH      = 0x8B87
    | GL_ACTIVE_ATTRIBUTES              = 0x8B89
    | GL_ACTIVE_ATTRIBUTE_MAX_LENGTH    = 0x8B8A
    | GL_SHADING_LANGUAGE_VERSION       = 0x8B8C
    | GL_CURRENT_PROGRAM                = 0x8B8D
    | GL_NEVER                          = 0x0200
    | GL_LESS                           = 0x0201
    | GL_EQUAL                          = 0x0202
    | GL_LEQUAL                         = 0x0203
    | GL_GREATER                        = 0x0204
    | GL_NOTEQUAL                       = 0x0205
    | GL_GEQUAL                         = 0x0206
    | GL_ALWAYS                         = 0x0207
    | GL_KEEP                           = 0x1E00
    | GL_REPLACE                        = 0x1E01
    | GL_INCR                           = 0x1E02
    | GL_DECR                           = 0x1E03
    | GL_INVERT                         = 0x150A
    | GL_INCR_WRAP                      = 0x8507
    | GL_DECR_WRAP                      = 0x8508
    | GL_VENDOR                         = 0x1F00
    | GL_RENDERER                       = 0x1F01
    | GL_VERSION                        = 0x1F02
    | GL_EXTENSIONS                     = 0x1F03
    | GL_NEAREST                        = 0x2600
    | GL_LINEAR                         = 0x2601
    | GL_NEAREST_MIPMAP_NEAREST         = 0x2700
    | GL_LINEAR_MIPMAP_NEAREST          = 0x2701
    | GL_NEAREST_MIPMAP_LINEAR          = 0x2702
    | GL_LINEAR_MIPMAP_LINEAR           = 0x2703
    | GL_TEXTURE_MAG_FILTER             = 0x2800
    | GL_TEXTURE_MIN_FILTER             = 0x2801
    | GL_TEXTURE_WRAP_S                 = 0x2802
    | GL_TEXTURE_WRAP_T                 = 0x2803
    | GL_TEXTURE                        = 0x1702
    | GL_TEXTURE_CUBE_MAP               = 0x8513
    | GL_TEXTURE_BINDING_CUBE_MAP       = 0x8514
    | GL_TEXTURE_CUBE_MAP_POSITIVE_X    = 0x8515
    | GL_TEXTURE_CUBE_MAP_NEGATIVE_X    = 0x8516
    | GL_TEXTURE_CUBE_MAP_POSITIVE_Y    = 0x8517
    | GL_TEXTURE_CUBE_MAP_NEGATIVE_Y    = 0x8518
    | GL_TEXTURE_CUBE_MAP_POSITIVE_Z    = 0x8519
    | GL_TEXTURE_CUBE_MAP_NEGATIVE_Z    = 0x851A
    | GL_MAX_CUBE_MAP_TEXTURE_SIZE      = 0x851C
    | GL_TEXTURE0                       = 0x84C0
    | GL_TEXTURE1                       = 0x84C1
    | GL_TEXTURE2                       = 0x84C2
    | GL_TEXTURE3                       = 0x84C3
    | GL_TEXTURE4                       = 0x84C4
    | GL_TEXTURE5                       = 0x84C5
    | GL_TEXTURE6                       = 0x84C6
    | GL_TEXTURE7                       = 0x84C7
    | GL_TEXTURE8                       = 0x84C8
    | GL_TEXTURE9                       = 0x84C9
    | GL_TEXTURE10                      = 0x84CA
    | GL_TEXTURE11                      = 0x84CB
    | GL_TEXTURE12                      = 0x84CC
    | GL_TEXTURE13                      = 0x84CD
    | GL_TEXTURE14                      = 0x84CE
    | GL_TEXTURE15                      = 0x84CF
    | GL_TEXTURE16                      = 0x84D0
    | GL_TEXTURE17                      = 0x84D1
    | GL_TEXTURE18                      = 0x84D2
    | GL_TEXTURE19                      = 0x84D3
    | GL_TEXTURE20                      = 0x84D4
    | GL_TEXTURE21                      = 0x84D5
    | GL_TEXTURE22                      = 0x84D6
    | GL_TEXTURE23                      = 0x84D7
    | GL_TEXTURE24                      = 0x84D8
    | GL_TEXTURE25                      = 0x84D9
    | GL_TEXTURE26                      = 0x84DA
    | GL_TEXTURE27                      = 0x84DB
    | GL_TEXTURE28                      = 0x84DC
    | GL_TEXTURE29                      = 0x84DD
    | GL_TEXTURE30                      = 0x84DE
    | GL_TEXTURE31                      = 0x84DF
    | GL_ACTIVE_TEXTURE                 = 0x84E0
    | GL_REPEAT                         = 0x2901
    | GL_CLAMP_TO_EDGE                  = 0x812F
    | GL_MIRRORED_REPEAT                = 0x8370
    | GL_FLOAT_VEC2                     = 0x8B50
    | GL_FLOAT_VEC3                     = 0x8B51
    | GL_FLOAT_VEC4                     = 0x8B52
    | GL_INT_VEC2                       = 0x8B53
    | GL_INT_VEC3                       = 0x8B54
    | GL_INT_VEC4                       = 0x8B55
    | GL_BOOL                           = 0x8B56
    | GL_BOOL_VEC2                      = 0x8B57
    | GL_BOOL_VEC3                      = 0x8B58
    | GL_BOOL_VEC4                      = 0x8B59
    | GL_FLOAT_MAT2                     = 0x8B5A
    | GL_FLOAT_MAT3                     = 0x8B5B
    | GL_FLOAT_MAT4                     = 0x8B5C
    | GL_SAMPLER_2D                     = 0x8B5E
    | GL_SAMPLER_CUBE                   = 0x8B60
    | GL_VERTEX_ATTRIB_ARRAY_ENABLED    = 0x8622
    | GL_VERTEX_ATTRIB_ARRAY_SIZE       = 0x8623
    | GL_VERTEX_ATTRIB_ARRAY_STRIDE     = 0x8624
    | GL_VERTEX_ATTRIB_ARRAY_TYPE       = 0x8625
    | GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A
    | GL_VERTEX_ATTRIB_ARRAY_POINTER    = 0x8645
    | GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F
    | GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A
    | GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B
    | GL_COMPILE_STATUS                 = 0x8B81
    | GL_INFO_LOG_LENGTH                = 0x8B84
    | GL_SHADER_SOURCE_LENGTH           = 0x8B88
    | GL_SHADER_COMPILER                = 0x8DFA
    | GL_SHADER_BINARY_FORMATS          = 0x8DF8
    | GL_NUM_SHADER_BINARY_FORMATS      = 0x8DF9
    | GL_LOW_single                      = 0x8DF0
    | GL_MEDIUM_single                   = 0x8DF1
    | GL_HIGH_single                     = 0x8DF2
    | GL_LOW_INT                        = 0x8DF3
    | GL_MEDIUM_INT                     = 0x8DF4
    | GL_HIGH_INT                       = 0x8DF5
    | GL_FRAMEBUFFER                    = 0x8D40
    | GL_RENDERBUFFER                   = 0x8D41
    | GL_RGBA4                          = 0x8056
    | GL_RGB5_A1                        = 0x8057
    | GL_RGB565                         = 0x8D62
    | GL_DEPTH_COMPONENT16              = 0x81A5
    | GL_STENCIL_INDEX8                 = 0x8D48
    | GL_RENDERBUFFER_WIDTH             = 0x8D42
    | GL_RENDERBUFFER_HEIGHT            = 0x8D43
    | GL_RENDERBUFFER_INTERNAL_FORMAT   = 0x8D44
    | GL_RENDERBUFFER_RED_SIZE          = 0x8D50
    | GL_RENDERBUFFER_GREEN_SIZE        = 0x8D51
    | GL_RENDERBUFFER_BLUE_SIZE         = 0x8D52
    | GL_RENDERBUFFER_ALPHA_SIZE        = 0x8D53
    | GL_RENDERBUFFER_DEPTH_SIZE        = 0x8D54
    | GL_RENDERBUFFER_STENCIL_SIZE      = 0x8D55
    | GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0
    | GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1
    | GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2
    | GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3
    | GL_COLOR_ATTACHMENT0              = 0x8CE0
    | GL_DEPTH_ATTACHMENT               = 0x8D00
    | GL_STENCIL_ATTACHMENT             = 0x8D20
    | GL_NONE                           = 0
    | GL_FRAMEBUFFER_COMPLETE           = 0x8CD5
    | GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6
    | GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7
    | GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9
    | GL_FRAMEBUFFER_UNSUPPORTED        = 0x8CDD
    | GL_FRAMEBUFFER_BINDING            = 0x8CA6
    | GL_RENDERBUFFER_BINDING           = 0x8CA7
    | GL_MAX_RENDERBUFFER_SIZE          = 0x84E8
    | GL_INVALID_FRAMEBUFFER_OPERATION  = 0x0506

    | GL_BGRA_EXT                       = 0x80E1

[<AutoOpen>]
[<System.Diagnostics.CodeAnalysis.SuppressMessage("NameConventions", "ValueIsUnused")>]
module private Native = 
#if WIN32
    let [<Literal>] DllName = @"native/angle"
#else
    let [<Literal>] DllName = @"GLESv2"
#endif
    [<Literal>]
    let MaxStrLength = 256
    
    [<Literal>]
    let MaxAttachedShaders = 64
       
    [<Literal>]
    let MaxShaderSize = 65536
    
    type GLboolean = byte
    
    type GLubyte = byte
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glActiveTexture(GLenum texture)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glAttachShader(int32 program, int32 shader)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glBindAttribLocation(int32 program, int32 index, [<MarshalAs(UnmanagedType.LPStr)>] string name)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glBindBuffer(GLenum target, int32 buffer)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glBindFramebuffer(GLenum target, int32 framebuffer)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glBindRenderbuffer(GLenum target, int32 renderbuffer)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glBindTexture(GLenum target, int32 texture)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glBlendColor(single red, single green, single blue, single alpha)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glBlendEquation(GLenum mode)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glBlendEquationSeparate(GLenum modeRGB, GLenum modeAlpha)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glBlendFunc(GLenum sfactor, GLenum dfactor)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glBlendFuncSeparate(GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glBufferData(GLenum target, int32 size, void * data, GLenum usage)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glBufferSubData(GLenum target, int32 offset, int32 size, void * data)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern GLenum glCheckFramebufferStatus(GLenum target)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glClear(int32 mask)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glClearColor(single red, single green, single blue, single alpha)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glClearDepthf(single d)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glClearStencil(int32 s)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glColorMask(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glCompileShader(int32 shader)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glCompressedTexImage2D(GLenum target, int32 level, GLenum internalformat, int32 width, int32 height, int32 border, int32 imageSize, void * data)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glCompressedTexSubImage2D(GLenum target, int32 level, int32 xoffset, int32 yoffset, int32 width, int32 height, GLenum format, int32 imageSize, void * data)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glCopyTexImage2D(GLenum target, int32 level, GLenum internalformat, int32 x, int32 y, int32 width, int32 height, int32 border)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glCopyTexSubImage2D(GLenum target, int32 level, int32 xoffset, int32 yoffset, int32 x, int32 y, int32 width, int32 height)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern int32 glCreateProgram()
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern int32 glCreateShader(GLenum type_)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glCullFace(GLenum mode)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glDeleteBuffers(int32 n, [<MarshalAs(UnmanagedType.LPArray)>] int32[] buffers)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glDeleteFramebuffers(int32 n, [<MarshalAs(UnmanagedType.LPArray)>] int32[] framebuffers)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glDeleteProgram(int32 program)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glDeleteRenderbuffers(int32 n, [<MarshalAs(UnmanagedType.LPArray)>] int32[] renderbuffers)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glDeleteShader(int32 shader)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glDeleteTextures(int32 n, [<MarshalAs(UnmanagedType.LPArray)>] int32[] textures)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glDepthFunc(GLenum func)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glDepthMask(GLboolean flag)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glDepthRangef(single n, single f)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glDetachShader(int32 program, int32 shader)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glDisable(GLenum cap)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glDisableVertexAttribArray(int32 index)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glDrawArrays(GLenum mode, int32 first, int32 count)

    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glDrawElements(GLenum mode, int32 count, GLenum type_, IntPtr indices)
    
    [<DllImport(DllName, EntryPoint = "glDrawElements", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glDrawElementsU16(GLenum mode, int32 count, GLenum type_, [<MarshalAs(UnmanagedType.LPArray)>] uint16[] indices)

    [<DllImport(DllName, EntryPoint = "glDrawElements", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glDrawElementsU32(GLenum mode, int32 count, GLenum type_, [<MarshalAs(UnmanagedType.LPArray)>] uint32[] indices)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glEnable(GLenum cap)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glEnableVertexAttribArray(int32 index)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glFinish()
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glFlush()
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glFramebufferRenderbuffer(GLenum target, GLenum attachment, GLenum renderbuffertarget, int32 renderbuffer)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glFramebufferTexture2D(GLenum target, GLenum attachment, GLenum textarget, int32 texture, int32 level)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glFrontFace(GLenum mode)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGenBuffers(int32 n, [<MarshalAs(UnmanagedType.LPArray)>] int32[] buffers)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGenerateMipmap(GLenum target)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGenFramebuffers(int32 n, [<MarshalAs(UnmanagedType.LPArray)>] int32[] framebuffers)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGenRenderbuffers(int32 n, [<MarshalAs(UnmanagedType.LPArray)>] int32[] renderbuffers)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGenTextures(int32 n, [<MarshalAs(UnmanagedType.LPArray)>] int32[] textures)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetActiveAttrib(int32 program, int32 index, int32 bufSize, [<Out>] int32& length, [<Out>] int32& size, [<Out>] GLenum& type_, [<MarshalAs(UnmanagedType.LPArray)>] byte[] name)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetActiveUniform(int32 program, int32 index, int32 bufSize, [<Out>] int32& length, [<Out>] int32& size, [<Out>] GLenum& type_, [<MarshalAs(UnmanagedType.LPArray)>] byte[] name)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetAttachedShaders(int32 program, int32 maxCount, [<Out>] int32& count, [<MarshalAs(UnmanagedType.LPArray)>] int32[] shaders)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern int32 glGetAttribLocation(int32 program, [<MarshalAs(UnmanagedType.LPStr)>] string name)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetBooleanv(GLenum pname, GLboolean * data)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetBufferParameteriv(GLenum target, GLenum pname, int32 * parms)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern GLenum glGetError()
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetsinglev(GLenum pname, single * data)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetFramebufferAttachmentParameteriv(GLenum target, GLenum attachment, GLenum pname, int32 * parms)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetIntegerv(GLenum pname, int32 * data)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetProgramiv(int32 program, GLenum pname, int32 * parms)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetProgramInfoLog(int32 program, int32 bufSize, [<Out>] int32& length, [<Out; MarshalAs(UnmanagedType.LPArray)>] byte[] infoLog)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetRenderbufferParameteriv(GLenum target, GLenum pname, int32 * parms)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetShaderiv(int32 shader, GLenum pname, int32 * parms)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetShaderInfoLog(int32 shader, int32 bufSize, [<Out>] int32& length, [<Out; MarshalAs(UnmanagedType.LPArray)>] byte[] infoLog)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetShaderPrecisionFormat(GLenum shadertype, GLenum precisiontype, int32 * range, int32 * precision)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetShaderSource(int32 shader, int32 bufSize, int32 * length, char * source)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern GLubyte* glGetString(GLenum name)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetTexParameterfv(GLenum target, GLenum pname, single * parms)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetTexParameteriv(GLenum target, GLenum pname, int32 * parms)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetUniformfv(int32 program, int32 location, single * parms)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetUniformiv(int32 program, int32 location, int32 * parms)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern int32 glGetUniformLocation(int32 program, [<MarshalAs(UnmanagedType.LPStr)>] string name)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetVertexAttribfv(int32 index, GLenum pname, single * parms)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glGetVertexAttribiv(int32 index, GLenum pname, int32 * parms)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    //extern void      glGetVertexAttribPointerv  (int32 index, GLenum pname, void **pointer);                                                                                                      
    extern unit glGetVertexAttribPointerv(int32 index, GLenum pname, IntPtr pointer)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glHint(GLenum target, GLenum mode)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern GLboolean glIsBuffer(int32 buffer)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern GLboolean glIsEnabled(GLenum cap)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern GLboolean glIsFramebuffer(int32 framebuffer)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern GLboolean glIsProgram(int32 program)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern GLboolean glIsRenderbuffer(int32 renderbuffer)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern GLboolean glIsShader(int32 shader)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern GLboolean glIsTexture(int32 texture)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glLineWidth(single width)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glLinkProgram(int32 program)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glPixelStorei(GLenum pname, int32 param)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glPolygonOffset(single factor, single units)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glReadPixels(int32 x, int32 y, int32 width, int32 height, GLenum format, GLenum type_, void * pixels)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glReleaseShaderCompiler()
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glRenderbufferStorage(GLenum target, GLenum internalformat, int32 width, int32 height)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glSampleCoverage(single value, GLboolean invert)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glScissor(int32 x, int32 y, int32 width, int32 height)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glShaderBinary(int32 count, int32 * shaders, GLenum binaryformat, void * binary, int32 length)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glShaderSource(int32 shader, int32 count, string[] str, [<MarshalAs(UnmanagedType.LPArray)>] int32[] length)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glStencilFunc(GLenum func, int32 ref_, int32 mask)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glStencilFuncSeparate(GLenum face, GLenum func, int32 ref_, int32 mask)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glStencilMask(int32 mask)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glStencilMaskSeparate(GLenum face, int32 mask)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glStencilOp(GLenum fail, GLenum zfail, GLenum zpass)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glStencilOpSeparate(GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glTexImage2D(GLenum target, int32 level, int32 internalformat, int32 width, int32 height, int32 border, GLenum format, GLenum type_, void * pixels)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glTexParameterf(GLenum target, GLenum pname, single param)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glTexParameterfv(GLenum target, GLenum pname, [<MarshalAs(UnmanagedType.LPArray)>] single[] parms)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glTexParameteri(GLenum target, GLenum pname, int32 param)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glTexParameteriv(GLenum target, GLenum pname, [<MarshalAs(UnmanagedType.LPArray)>] int32[] parms)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glTexSubImage2D(GLenum target, int32 level, int32 xoffset, int32 yoffset, int32 width, int32 height, GLenum format, GLenum type_, void * pixels)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUniform1f(int32 location, single v0)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUniform1fv(int32 location, int32 count, [<MarshalAs(UnmanagedType.LPArray)>] single[] value)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUniform1i(int32 location, int32 v0)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUniform1iv(int32 location, int32 count, [<MarshalAs(UnmanagedType.LPArray)>] int32[] value)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUniform2f(int32 location, single v0, single v1)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUniform2fv(int32 location, int32 count, [<MarshalAs(UnmanagedType.LPArray)>] single[] value)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUniform2i(int32 location, int32 v0, int32 v1)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUniform2iv(int32 location, int32 count, [<MarshalAs(UnmanagedType.LPArray)>] int32[] value)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUniform3f(int32 location, single v0, single v1, single v2)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUniform3fv(int32 location, int32 count, [<MarshalAs(UnmanagedType.LPArray)>] single[] value)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUniform3i(int32 location, int32 v0, int32 v1, int32 v2)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUniform3iv(int32 location, int32 count, [<MarshalAs(UnmanagedType.LPArray)>] int32[] value)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUniform4f(int32 location, single v0, single v1, single v2, single v3)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUniform4fv(int32 location, int32 count, [<MarshalAs(UnmanagedType.LPArray)>] single[] value)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUniform4i(int32 location, int32 v0, int32 v1, int32 v2, int32 v3)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUniform4iv(int32 location, int32 count, [<MarshalAs(UnmanagedType.LPArray)>] int32[] value)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUniformMatrix2fv(int32 location, int32 count, GLboolean transpose, [<MarshalAs(UnmanagedType.LPArray)>] single[] value)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUniformMatrix3fv(int32 location, int32 count, GLboolean transpose, [<MarshalAs(UnmanagedType.LPArray)>] single[] value)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUniformMatrix4fv(int32 location, int32 count, GLboolean transpose, [<MarshalAs(UnmanagedType.LPArray)>] single[] value)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glUseProgram(int32 program)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glValidateProgram(int32 program)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glVertexAttrib1f(int32 index, single x)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glVertexAttrib1fv(int32 index, single * v)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glVertexAttrib2f(int32 index, single x, single y)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glVertexAttrib2fv(int32 index, single * v)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glVertexAttrib3f(int32 index, single x, single y, single z)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glVertexAttrib3fv(int32 index, single * v)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glVertexAttrib4f(int32 index, single x, single y, single z, single w)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glVertexAttrib4fv(int32 index, single * v)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glVertexAttribPointer(int32 index, int32 size, GLenum type_, GLboolean normalized, int32 stride, IntPtr pointer)
    
    [<DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)>]
    extern unit glViewport(int32 x, int32 y, int32 width, int32 height)

let b2GLb (b: bool) = if b then 1uy else 0uy

let glActiveTexture         = glActiveTexture
let glAttachShader          = glAttachShader
let glBindAttribLocation    = glBindAttribLocation
let glBindBuffer            = glBindBuffer           
let glBindFramebuffer       = glBindFramebuffer      
let glBindRenderbuffer      = glBindRenderbuffer     
let glBindTexture           = glBindTexture          
let glBlendColor            = glBlendColor           
let glBlendEquation         = glBlendEquation        
let glBlendEquationSeparate = glBlendEquationSeparate
let glBlendFunc             = glBlendFunc            
let glBlendFuncSeparate     = glBlendFuncSeparate   

let glSizeOf<'T> = Marshal.SizeOf(typedefof<'T>)

let glBufferDataInit<'T when 'T : struct> (target, count: int, usage) =
    glBufferData (target, glSizeOf<'T> * count, IntPtr.Zero, usage)

let glBufferData<'T when 'T : struct> (target, data: 'T[], usage) =
    let gch = GCHandle.Alloc (data, GCHandleType.Pinned)
    glBufferData (target, glSizeOf<'T> * data.Length, gch.AddrOfPinnedObject(), usage)
    gch.Free ()

let glBufferSubData<'T when 'T : struct> (target, offset, data: 'T[]) =
    let gch = GCHandle.Alloc (data, GCHandleType.Pinned)  
    glBufferSubData (target, offset, glSizeOf<'T> * data.Length, gch.AddrOfPinnedObject ())
    gch.Free ()

[<StructAttribute; StructLayoutAttribute(LayoutKind.Sequential)>]
type ColorRGB<'T> =
    val r: 'T
    val g: 'T
    val b: 'T

    new(r, g, b) = { r = r; g = g; b = b }

[<StructAttribute; StructLayoutAttribute(LayoutKind.Sequential)>]
type ColorRGBA<'T> =
    val r: 'T
    val g: 'T
    val b: 'T
    val a: 'T

    new(r, g, b, a) = { r = r; g = g; b = b; a = a}

let glCheckFramebufferStatus= glCheckFramebufferStatus
let glClear                 = glClear                
let glClearColor            = glClearColor           
let glClearDepthf           = glClearDepthf          
let glClearStencil          = glClearStencil         
let glColorMask (r: bool, g: bool, b: bool, a: bool) =  glColorMask(r |> b2GLb, g |> b2GLb, b |> b2GLb, a |> b2GLb)
let glCompileShader         = glCompileShader
      
let glCompressedTexImage2D<'T when 'T : struct> (target, level, internalformat, width, height, border, imageSize, data: 'T[]) =
    let gch = GCHandle.Alloc (data, GCHandleType.Pinned)  
    glCompressedTexImage2D (target, level, internalformat, width, height, border, imageSize, gch.AddrOfPinnedObject ())
    gch.Free ()

let glCompressedTexSubImage<'T when 'T : struct> (target, level, xoffset, yoffset, width, height, format, imageSize, data: 'T[]) =
    let gch = GCHandle.Alloc (data, GCHandleType.Pinned)  
    glCompressedTexSubImage2D  (target, level, xoffset, yoffset, width, height, format, imageSize, gch.AddrOfPinnedObject ())
    gch.Free ()

let glCopyTexImage2D        = glCopyTexImage2D      
let glCopyTexSubImage2D     = glCopyTexSubImage2D   
let glCreateProgram         = glCreateProgram        
let glCreateShader e        = glCreateShader e        
let glCullFace              = glCullFace             

let glDeleteBuffers (buffers: int32[]) =  glDeleteBuffers (buffers.Length, buffers)

let glDeleteFramebuffers (framebuffers: int32[]) = glDeleteFramebuffers (framebuffers.Length, framebuffers)

let glDeleteProgram         = glDeleteProgram        

let glDeleteRenderbuffers (renderbuffers: int32[]) = glDeleteRenderbuffers  (renderbuffers.Length, renderbuffers)

let glDeleteShader          = glDeleteShader         

let glDeleteTextures (textures: int32[]) = glDeleteTextures (textures.Length, textures)

let glDepthFunc             = glDepthFunc            

let glDepthMask b           = glDepthMask (b |> b2GLb)

let glDepthRangef           = glDepthRangef          
let glDetachShader          = glDetachShader         
let glDisable               = glDisable              
let glDisableVertexAttribArray = glDisableVertexAttribArray
let glDrawArrays            = glDrawArrays           

let glDrawElementsPtr       = glDrawElements

let glDrawElements    (mode, count, type_, offset: int) = glDrawElements (mode, count, type_, IntPtr.Add(IntPtr.Zero, offset))
let glDrawElementsU16 (mode, count, indices: uint16[]) = glDrawElementsU16 (mode, count, GLenum.GL_UNSIGNED_SHORT, indices)
let glDrawElementsU32 (mode, count, indices: uint32[]) = glDrawElementsU32 (mode, count, GLenum.GL_UNSIGNED_INT, indices)
let glDrawElementsTri16 (tris: FsMath3D.Geometry.tri16[]) =
    let gch = GCHandle.Alloc (tris, GCHandleType.Pinned)  
    glDrawElementsPtr (GLenum.GL_TRIANGLES, tris.Length * 3, GLenum.GL_UNSIGNED_SHORT, gch.AddrOfPinnedObject ())
    gch.Free()

let glDrawElementsTri32 (tris: FsMath3D.Geometry.tri32[]) =
    let gch = GCHandle.Alloc (tris, GCHandleType.Pinned)  
    glDrawElementsPtr (GLenum.GL_TRIANGLES, tris.Length * 3, GLenum.GL_UNSIGNED_INT, gch.AddrOfPinnedObject ())
    gch.Free()

let glEnable                = glEnable               
let glEnableVertexAttribArray = glEnableVertexAttribArray
let glFinish                = glFinish               
let glFlush                 = glFlush                
let glFramebufferRenderbuff = glFramebufferRenderbuffer
let glFramebufferTexture2D  = glFramebufferTexture2D   
let glFrontFace             = glFrontFace  
          
let private _generator n f  =
    let buffers = Array.zeroCreate<int32> n
    f (n, buffers)
    buffers

let glGenBuffers n          = _generator n glGenBuffers
let glGenerateMipmap        = glGenerateMipmap
let glGenFramebuffers n     = _generator n glGenFramebuffers 
let glGenRenderbuffers n    = _generator n glGenRenderbuffers
let glGenTextures n         = _generator n glGenTextures     

type VariableInfo = {
    Name    : string
    Size    : int
    Type    : GLenum
}

type ShaderVariable =
    | Attribute of VariableInfo
    | Uniform   of VariableInfo

let [<LiteralAttribute>] MAX_NAME_SIZE = 512
let [<LiteralAttribute>] MAX_SHADERS   = 512
let [<LiteralAttribute>] MAX_LOG_SIZE  = 65536

let glGetActiveAttrib (program, index) =
    let buff = Array.zeroCreate<byte> MAX_NAME_SIZE
    let mutable length, size, type_ = 0, 0, GLenum.GL_ZERO
    glGetActiveAttrib (program, index, buff.Length - 1, &length, &size, &type_, buff)

    Attribute { Name = Text.Encoding.UTF8.GetString(buff, 0, length); Size = size; Type = type_ }

let glGetActiveUniform (program, index) =
    let buff = Array.zeroCreate<byte> MAX_NAME_SIZE
    let mutable length, size, type_ = 0, 0, GLenum.GL_ZERO
    glGetActiveUniform (program, index, buff.Length - 1, &length, &size, &type_, buff)

    Uniform { Name = Text.Encoding.UTF8.GetString(buff, 0, length); Size = size; Type = type_ }

let glGetAttachedShaders program   =
    let shaders = Array.zeroCreate<int32> MAX_SHADERS
    let mutable count = 0
    glGetAttachedShaders (program, shaders.Length, &count, shaders)
    shaders.[0 .. count - 1]

let glGetAttribLocation     = glGetAttribLocation    

//let glGetBooleanv           = glGetBooleanv          (GLenum pname, GLboolean *data)
//let glGetBufferParameteriv  = glGetBufferParameteriv (GLenum target, GLenum pname, int32 *parms)
let glGetError              = glGetError             
//let glGetsinglev            = glGetsinglev            (GLenum pname, single *data)
//let glGetFramebufferAttachm = glGetFramebufferAttachmentParameteriv (GLenum target, GLenum attachment, GLenum pname, int32 *parms)
//let glGetIntegerv           = glGetIntegerv          (GLenum pname, int32 *data)
//let glGetProgramiv          = glGetProgramiv         (int32 program, GLenum pname, int32 *parms)

let glGetProgramInfoLog shader =
    let infoLog = Array.zeroCreate<byte> MAX_LOG_SIZE
    let mutable length, size, type_ = 0, 0, GLenum.GL_ZERO
    glGetProgramInfoLog (shader, infoLog.Length, &length, infoLog)
    Text.Encoding.UTF8.GetString(infoLog, 0, length)

//let glGetRenderbufferParame = glGetRenderbufferParameteriv   (GLenum target, GLenum pname, int32 *parms)
//let glGetShaderiv           = glGetShaderiv          (int32 shader, GLenum pname, int32 *parms)

let glGetShaderInfoLog shader =
    let infoLog = Array.zeroCreate<byte> MAX_LOG_SIZE
    let mutable length, size, type_ = 0, 0, GLenum.GL_ZERO
    glGetShaderInfoLog (shader, infoLog.Length, &length, infoLog)
    Text.Encoding.UTF8.GetString(infoLog, 0, length)

//let glGetShaderPrecisionFor = glGetShaderPrecisionFormat (GLenum shadertype, GLenum precisiontype, int32 *range, int32 *precision)
//let glGetShaderSource       = glGetShaderSource      (int32 shader, int32 bufSize, int32 *length, char *source)
//let glGetString             = glGetString            (GLenum name)
//let glGetTexParameterfv     = glGetTexParameterfv    (GLenum target, GLenum pname, single *parms)
//let glGetTexParameteriv     = glGetTexParameteriv    (GLenum target, GLenum pname, int32 *parms)
//let glGetUniformfv          = glGetUniformfv         (int32 program, int32 location, single *parms)
//let glGetUniformiv          = glGetUniformiv         (int32 program, int32 location, int32 *parms)
let glGetUniformLocation     = glGetUniformLocation
//let glGetVertexAttribfv     = glGetVertexAttribfv     (int32 index, GLenum pname, single *parms)
//let glGetVertexAttribiv     = glGetVertexAttribiv     (int32 index, GLenum pname, int32 *parms)
////let glGetVertexAttribPointerv  (int32 index, GLenum pname, void **pointer);                                                                                                      
//let glGetVertexAttribPointerv = glGetVertexAttribPointerv  (int32 index, GLenum pname, IntPtr pointer)
let glHint                  = glHint
let glIsBuffer              = glIsBuffer
let glIsEnabled             = glIsEnabled
let glIsFramebuffer         = glIsFramebuffer
let glIsProgram             = glIsProgram
let glIsRenderbuffer        = glIsRenderbuffer
let glIsShader              = glIsShader
let glIsTexture             = glIsTexture
let glLineWidth             = glLineWidth
let glLinkProgram           = glLinkProgram
let glPixelStorei           = glPixelStorei
let glPolygonOffset         = glPolygonOffset

let glReadPixels<'T when 'T: struct> (x, y, width, height, format, type_, pixels: 'T[]) =
    let gch = GCHandle.Alloc (pixels, GCHandleType.Pinned)
    glReadPixels (x, y, width, height, format, type_, gch.AddrOfPinnedObject ())
    gch.Free ()

let glReleaseShaderCompiler = glReleaseShaderCompiler
let glRenderbufferStorage   = glRenderbufferStorage

//let glSampleCoverage        = glSampleCoverage       (single value, GLboolean invert)

let glScissor               = glScissor

//let glShaderBinary          = glShaderBinary         (int32 count, int32 *shaders, GLenum binaryformat, void *binary, int32 length)

let glShaderSource (shader: int, sources: string[]) =
    let lengths = sources |> Array.map String.length
    glShaderSource (shader, sources.Length, sources, lengths)

let glStencilFunc           = glStencilFunc
let glStencilFuncSeparate   = glStencilFuncSeparate
let glStencilMask           = glStencilMask
let glStencilMaskSeparate   = glStencilMaskSeparate
let glStencilOp             = glStencilOp
let glStencilOpSeparate     = glStencilOpSeparate

let glTexImage2DPtr(target, level, internalformat, width, height, border, format, type_, pixels) =
    glTexImage2D (target, level, internalformat, width, height, border, format, type_, pixels)

let glTexImage2D<'T when 'T: struct> (target, level, internalformat, width, height, border, format, type_, pixels: 'T[]) =
    let gch = GCHandle.Alloc(pixels, GCHandleType.Pinned)
    glTexImage2D (target, level, internalformat, width, height, border, format, type_, gch.AddrOfPinnedObject ())
    gch.Free ()

let glTexParameterf         = glTexParameterf
let glTexParameterfv        = glTexParameterfv
let glTexParameteri         = glTexParameteri
let glTexParameteriv        = glTexParameteriv

let glTexSubImage2D<'T when 'T: struct> (target, level, xoffset, yoffset, width, height, format, type_, pixels: 'T[]) =
    let gch = GCHandle.Alloc (pixels, GCHandleType.Pinned)
    glTexSubImage2D (target, level, xoffset, yoffset, width, height, format, type_, gch.AddrOfPinnedObject ())
    gch.Free ()

let glUniform1f             = glUniform1f
let glUniform1fv            = glUniform1fv
let glUniform1i             = glUniform1i
let glUniform1iv            = glUniform1iv           
let glUniform2f             = glUniform2f
let glUniform2fv            = glUniform2fv           
let glUniform2i             = glUniform2i
let glUniform2iv            = glUniform2iv           
let glUniform3f             = glUniform3f
let glUniform3fv            = glUniform3fv           
let glUniform3i             = glUniform3i
let glUniform3iv            = glUniform3iv           
let glUniform4f             = glUniform4f
let glUniform4fv            = glUniform4fv           
let glUniform4i             = glUniform4i
let glUniform4iv            = glUniform4iv           
let glUniformMatrix2fv      = glUniformMatrix2fv
let glUniformMatrix3fv      = glUniformMatrix3fv
let glUniformMatrix4fv      = glUniformMatrix4fv
let glUseProgram            = glUseProgram
let glValidateProgram       = glValidateProgram
let glVertexAttrib1f        = glVertexAttrib1f

//let glVertexAttrib1fv       = glVertexAttrib1fv      (int32 index, single *v)
let glVertexAttrib2f        = glVertexAttrib2f
//let glVertexAttrib2fv       = glVertexAttrib2fv      (int32 index, single *v)
let glVertexAttrib3f        = glVertexAttrib3f
//let glVertexAttrib3fv       = glVertexAttrib3fv      (int32 index, single *v)
let glVertexAttrib4f        = glVertexAttrib4f
//let glVertexAttrib4fv       = glVertexAttrib4fv      (int32 index, single *v)

/// only allow buffers to be used with glVertexAttribPointer
let glVertexAttribPointer (index, size, type_, normalized, stride, pointer : int) = glVertexAttribPointer  (index, size, type_, (if normalized then byte(1) else byte(0)), stride, IntPtr.Add(nativeint(0), pointer))
let glViewport              = glViewport