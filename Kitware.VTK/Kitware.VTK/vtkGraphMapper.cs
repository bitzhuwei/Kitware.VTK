using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGraphMapper : vtkMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphMapper";

		public new static readonly string MRClassNameKey;

		static vtkGraphMapper()
		{
			vtkGraphMapper.MRClassNameKey = "class vtkGraphMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphMapper"));
		}

		public vtkGraphMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphMapper New()
		{
			vtkGraphMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphMapper.vtkGraphMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGraphMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGraphMapper.vtkGraphMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_AddIconType_01(HandleRef pThis, string type, int index);

		public void AddIconType(string type, int index)
		{
			vtkGraphMapper.vtkGraphMapper_AddIconType_01(base.GetCppThis(), type, index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_ApplyViewTheme_02(HandleRef pThis, HandleRef theme);

		public virtual void ApplyViewTheme(vtkViewTheme theme)
		{
			vtkGraphMapper.vtkGraphMapper_ApplyViewTheme_02(base.GetCppThis(), (theme == null) ? default(HandleRef) : theme.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_ClearIconTypes_03(HandleRef pThis);

		public void ClearIconTypes()
		{
			vtkGraphMapper.vtkGraphMapper_ClearIconTypes_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_ColorEdgesOff_04(HandleRef pThis);

		public void ColorEdgesOff()
		{
			vtkGraphMapper.vtkGraphMapper_ColorEdgesOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_ColorEdgesOn_05(HandleRef pThis);

		public void ColorEdgesOn()
		{
			vtkGraphMapper.vtkGraphMapper_ColorEdgesOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_ColorVerticesOff_06(HandleRef pThis);

		public void ColorVerticesOff()
		{
			vtkGraphMapper.vtkGraphMapper_ColorVerticesOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_ColorVerticesOn_07(HandleRef pThis);

		public void ColorVerticesOn()
		{
			vtkGraphMapper.vtkGraphMapper_ColorVerticesOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_EdgeVisibilityOff_08(HandleRef pThis);

		public virtual void EdgeVisibilityOff()
		{
			vtkGraphMapper.vtkGraphMapper_EdgeVisibilityOff_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_EdgeVisibilityOn_09(HandleRef pThis);

		public virtual void EdgeVisibilityOn()
		{
			vtkGraphMapper.vtkGraphMapper_EdgeVisibilityOn_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_EnableEdgesByArrayOff_10(HandleRef pThis);

		public virtual void EnableEdgesByArrayOff()
		{
			vtkGraphMapper.vtkGraphMapper_EnableEdgesByArrayOff_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_EnableEdgesByArrayOn_11(HandleRef pThis);

		public virtual void EnableEdgesByArrayOn()
		{
			vtkGraphMapper.vtkGraphMapper_EnableEdgesByArrayOn_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_EnableVerticesByArrayOff_12(HandleRef pThis);

		public virtual void EnableVerticesByArrayOff()
		{
			vtkGraphMapper.vtkGraphMapper_EnableVerticesByArrayOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_EnableVerticesByArrayOn_13(HandleRef pThis);

		public virtual void EnableVerticesByArrayOn()
		{
			vtkGraphMapper.vtkGraphMapper_EnableVerticesByArrayOn_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphMapper_GetBounds_14(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkGraphMapper.vtkGraphMapper_GetBounds_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_GetBounds_15(HandleRef pThis, IntPtr bounds);

		public override void GetBounds(IntPtr bounds)
		{
			vtkGraphMapper.vtkGraphMapper_GetBounds_15(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkGraphMapper_GetColorEdges_16(HandleRef pThis);

		public bool GetColorEdges()
		{
			return vtkGraphMapper.vtkGraphMapper_GetColorEdges_16(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkGraphMapper_GetColorVertices_17(HandleRef pThis);

		public bool GetColorVertices()
		{
			return vtkGraphMapper.vtkGraphMapper_GetColorVertices_17(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphMapper_GetEdgeColorArrayName_18(HandleRef pThis);

		public string GetEdgeColorArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkGraphMapper.vtkGraphMapper_GetEdgeColorArrayName_18(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkGraphMapper_GetEdgeLineWidth_19(HandleRef pThis);

		public virtual float GetEdgeLineWidth()
		{
			return vtkGraphMapper.vtkGraphMapper_GetEdgeLineWidth_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphMapper_GetEdgeLookupTable_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLookupTable GetEdgeLookupTable()
		{
			vtkLookupTable vtkLookupTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphMapper.vtkGraphMapper_GetEdgeLookupTable_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTable = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTable.Register(null);
				}
			}
			return vtkLookupTable;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkGraphMapper_GetEdgeVisibility_21(HandleRef pThis);

		public bool GetEdgeVisibility()
		{
			return vtkGraphMapper.vtkGraphMapper_GetEdgeVisibility_21(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGraphMapper_GetEnableEdgesByArray_22(HandleRef pThis);

		public virtual int GetEnableEdgesByArray()
		{
			return vtkGraphMapper.vtkGraphMapper_GetEnableEdgesByArray_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGraphMapper_GetEnableVerticesByArray_23(HandleRef pThis);

		public virtual int GetEnableVerticesByArray()
		{
			return vtkGraphMapper.vtkGraphMapper_GetEnableVerticesByArray_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphMapper_GetEnabledEdgesArrayName_24(HandleRef pThis);

		public virtual string GetEnabledEdgesArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkGraphMapper.vtkGraphMapper_GetEnabledEdgesArrayName_24(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphMapper_GetEnabledVerticesArrayName_25(HandleRef pThis);

		public virtual string GetEnabledVerticesArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkGraphMapper.vtkGraphMapper_GetEnabledVerticesArrayName_25(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphMapper_GetIconArrayName_26(HandleRef pThis);

		public string GetIconArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkGraphMapper.vtkGraphMapper_GetIconArrayName_26(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphMapper_GetIconSize_27(HandleRef pThis);

		public IntPtr GetIconSize()
		{
			return vtkGraphMapper.vtkGraphMapper_GetIconSize_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphMapper_GetIconTexture_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkTexture GetIconTexture()
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphMapper.vtkGraphMapper_GetIconTexture_28(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkGraphMapper_GetIconVisibility_29(HandleRef pThis);

		public bool GetIconVisibility()
		{
			return vtkGraphMapper.vtkGraphMapper_GetIconVisibility_29(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphMapper_GetInput_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGraph GetInput()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphMapper.vtkGraphMapper_GetInput_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkGraphMapper_GetMTime_31(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkGraphMapper.vtkGraphMapper_GetMTime_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkGraphMapper_GetScaledGlyphs_32(HandleRef pThis);

		public virtual bool GetScaledGlyphs()
		{
			return vtkGraphMapper.vtkGraphMapper_GetScaledGlyphs_32(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphMapper_GetScalingArrayName_33(HandleRef pThis);

		public virtual string GetScalingArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkGraphMapper.vtkGraphMapper_GetScalingArrayName_33(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphMapper_GetVertexColorArrayName_34(HandleRef pThis);

		public string GetVertexColorArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkGraphMapper.vtkGraphMapper_GetVertexColorArrayName_34(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphMapper_GetVertexLookupTable_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLookupTable GetVertexLookupTable()
		{
			vtkLookupTable vtkLookupTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphMapper.vtkGraphMapper_GetVertexLookupTable_35(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTable = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTable.Register(null);
				}
			}
			return vtkLookupTable;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkGraphMapper_GetVertexPointSize_36(HandleRef pThis);

		public virtual float GetVertexPointSize()
		{
			return vtkGraphMapper.vtkGraphMapper_GetVertexPointSize_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_IconVisibilityOff_37(HandleRef pThis);

		public virtual void IconVisibilityOff()
		{
			vtkGraphMapper.vtkGraphMapper_IconVisibilityOff_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_IconVisibilityOn_38(HandleRef pThis);

		public virtual void IconVisibilityOn()
		{
			vtkGraphMapper.vtkGraphMapper_IconVisibilityOn_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGraphMapper_IsA_39(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGraphMapper.vtkGraphMapper_IsA_39(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGraphMapper_IsTypeOf_40(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGraphMapper.vtkGraphMapper_IsTypeOf_40(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphMapper_NewInstance_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGraphMapper NewInstance()
		{
			vtkGraphMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphMapper.vtkGraphMapper_NewInstance_42(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_ReleaseGraphicsResources_43(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkGraphMapper.vtkGraphMapper_ReleaseGraphicsResources_43(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_Render_44(HandleRef pThis, HandleRef ren, HandleRef act);

		public override void Render(vtkRenderer ren, vtkActor act)
		{
			vtkGraphMapper.vtkGraphMapper_Render_44(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphMapper_SafeDownCast_45(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphMapper SafeDownCast(vtkObjectBase o)
		{
			vtkGraphMapper vtkGraphMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphMapper.vtkGraphMapper_SafeDownCast_45((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphMapper = (vtkGraphMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphMapper.Register(null);
				}
			}
			return vtkGraphMapper;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_ScaledGlyphsOff_46(HandleRef pThis);

		public virtual void ScaledGlyphsOff()
		{
			vtkGraphMapper.vtkGraphMapper_ScaledGlyphsOff_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_ScaledGlyphsOn_47(HandleRef pThis);

		public virtual void ScaledGlyphsOn()
		{
			vtkGraphMapper.vtkGraphMapper_ScaledGlyphsOn_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_SetColorEdges_48(HandleRef pThis, byte vis);

		public void SetColorEdges(bool vis)
		{
			vtkGraphMapper.vtkGraphMapper_SetColorEdges_48(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_SetColorVertices_49(HandleRef pThis, byte vis);

		public void SetColorVertices(bool vis)
		{
			vtkGraphMapper.vtkGraphMapper_SetColorVertices_49(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_SetEdgeColorArrayName_50(HandleRef pThis, string name);

		public void SetEdgeColorArrayName(string name)
		{
			vtkGraphMapper.vtkGraphMapper_SetEdgeColorArrayName_50(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_SetEdgeLineWidth_51(HandleRef pThis, float width);

		public void SetEdgeLineWidth(float width)
		{
			vtkGraphMapper.vtkGraphMapper_SetEdgeLineWidth_51(base.GetCppThis(), width);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_SetEdgeVisibility_52(HandleRef pThis, byte vis);

		public void SetEdgeVisibility(bool vis)
		{
			vtkGraphMapper.vtkGraphMapper_SetEdgeVisibility_52(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_SetEnableEdgesByArray_53(HandleRef pThis, int _arg);

		public virtual void SetEnableEdgesByArray(int _arg)
		{
			vtkGraphMapper.vtkGraphMapper_SetEnableEdgesByArray_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_SetEnableVerticesByArray_54(HandleRef pThis, int _arg);

		public virtual void SetEnableVerticesByArray(int _arg)
		{
			vtkGraphMapper.vtkGraphMapper_SetEnableVerticesByArray_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_SetEnabledEdgesArrayName_55(HandleRef pThis, string _arg);

		public virtual void SetEnabledEdgesArrayName(string _arg)
		{
			vtkGraphMapper.vtkGraphMapper_SetEnabledEdgesArrayName_55(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_SetEnabledVerticesArrayName_56(HandleRef pThis, string _arg);

		public virtual void SetEnabledVerticesArrayName(string _arg)
		{
			vtkGraphMapper.vtkGraphMapper_SetEnabledVerticesArrayName_56(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_SetIconAlignment_57(HandleRef pThis, int alignment);

		public void SetIconAlignment(int alignment)
		{
			vtkGraphMapper.vtkGraphMapper_SetIconAlignment_57(base.GetCppThis(), alignment);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_SetIconArrayName_58(HandleRef pThis, string name);

		public void SetIconArrayName(string name)
		{
			vtkGraphMapper.vtkGraphMapper_SetIconArrayName_58(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_SetIconSize_59(HandleRef pThis, IntPtr size);

		public void SetIconSize(IntPtr size)
		{
			vtkGraphMapper.vtkGraphMapper_SetIconSize_59(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_SetIconTexture_60(HandleRef pThis, HandleRef texture);

		public void SetIconTexture(vtkTexture texture)
		{
			vtkGraphMapper.vtkGraphMapper_SetIconTexture_60(base.GetCppThis(), (texture == null) ? default(HandleRef) : texture.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_SetIconVisibility_61(HandleRef pThis, byte vis);

		public void SetIconVisibility(bool vis)
		{
			vtkGraphMapper.vtkGraphMapper_SetIconVisibility_61(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_SetInput_62(HandleRef pThis, HandleRef input);

		public void SetInput(vtkGraph input)
		{
			vtkGraphMapper.vtkGraphMapper_SetInput_62(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_SetScaledGlyphs_63(HandleRef pThis, byte arg);

		public void SetScaledGlyphs(bool arg)
		{
			vtkGraphMapper.vtkGraphMapper_SetScaledGlyphs_63(base.GetCppThis(), arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_SetScalingArrayName_64(HandleRef pThis, string _arg);

		public virtual void SetScalingArrayName(string _arg)
		{
			vtkGraphMapper.vtkGraphMapper_SetScalingArrayName_64(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_SetVertexColorArrayName_65(HandleRef pThis, string name);

		public void SetVertexColorArrayName(string name)
		{
			vtkGraphMapper.vtkGraphMapper_SetVertexColorArrayName_65(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphMapper_SetVertexPointSize_66(HandleRef pThis, float size);

		public void SetVertexPointSize(float size)
		{
			vtkGraphMapper.vtkGraphMapper_SetVertexPointSize_66(base.GetCppThis(), size);
		}
	}
}
