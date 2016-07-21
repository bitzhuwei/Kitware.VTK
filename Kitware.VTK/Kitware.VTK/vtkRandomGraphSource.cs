using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRandomGraphSource : vtkGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRandomGraphSource";

		public new static readonly string MRClassNameKey;

		static vtkRandomGraphSource()
		{
			vtkRandomGraphSource.MRClassNameKey = "class vtkRandomGraphSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRandomGraphSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRandomGraphSource"));
		}

		public vtkRandomGraphSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRandomGraphSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRandomGraphSource New()
		{
			vtkRandomGraphSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRandomGraphSource.vtkRandomGraphSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRandomGraphSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRandomGraphSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRandomGraphSource.vtkRandomGraphSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_AllowParallelEdgesOff_01(HandleRef pThis);

		public virtual void AllowParallelEdgesOff()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_AllowParallelEdgesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_AllowParallelEdgesOn_02(HandleRef pThis);

		public virtual void AllowParallelEdgesOn()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_AllowParallelEdgesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_AllowSelfLoopsOff_03(HandleRef pThis);

		public virtual void AllowSelfLoopsOff()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_AllowSelfLoopsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_AllowSelfLoopsOn_04(HandleRef pThis);

		public virtual void AllowSelfLoopsOn()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_AllowSelfLoopsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_DirectedOff_05(HandleRef pThis);

		public virtual void DirectedOff()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_DirectedOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_DirectedOn_06(HandleRef pThis);

		public virtual void DirectedOn()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_DirectedOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_GeneratePedigreeIdsOff_07(HandleRef pThis);

		public virtual void GeneratePedigreeIdsOff()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_GeneratePedigreeIdsOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_GeneratePedigreeIdsOn_08(HandleRef pThis);

		public virtual void GeneratePedigreeIdsOn()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_GeneratePedigreeIdsOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkRandomGraphSource_GetAllowParallelEdges_09(HandleRef pThis);

		public virtual bool GetAllowParallelEdges()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetAllowParallelEdges_09(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkRandomGraphSource_GetAllowSelfLoops_10(HandleRef pThis);

		public virtual bool GetAllowSelfLoops()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetAllowSelfLoops_10(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkRandomGraphSource_GetDirected_11(HandleRef pThis);

		public virtual bool GetDirected()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetDirected_11(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRandomGraphSource_GetEdgePedigreeIdArrayName_12(HandleRef pThis);

		public virtual string GetEdgePedigreeIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRandomGraphSource.vtkRandomGraphSource_GetEdgePedigreeIdArrayName_12(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkRandomGraphSource_GetEdgeProbability_13(HandleRef pThis);

		public virtual double GetEdgeProbability()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetEdgeProbability_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkRandomGraphSource_GetEdgeProbabilityMaxValue_14(HandleRef pThis);

		public virtual double GetEdgeProbabilityMaxValue()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetEdgeProbabilityMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkRandomGraphSource_GetEdgeProbabilityMinValue_15(HandleRef pThis);

		public virtual double GetEdgeProbabilityMinValue()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetEdgeProbabilityMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRandomGraphSource_GetEdgeWeightArrayName_16(HandleRef pThis);

		public virtual string GetEdgeWeightArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRandomGraphSource.vtkRandomGraphSource_GetEdgeWeightArrayName_16(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkRandomGraphSource_GetGeneratePedigreeIds_17(HandleRef pThis);

		public virtual bool GetGeneratePedigreeIds()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetGeneratePedigreeIds_17(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkRandomGraphSource_GetIncludeEdgeWeights_18(HandleRef pThis);

		public virtual bool GetIncludeEdgeWeights()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetIncludeEdgeWeights_18(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRandomGraphSource_GetNumberOfEdges_19(HandleRef pThis);

		public virtual int GetNumberOfEdges()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetNumberOfEdges_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRandomGraphSource_GetNumberOfEdgesMaxValue_20(HandleRef pThis);

		public virtual int GetNumberOfEdgesMaxValue()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetNumberOfEdgesMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRandomGraphSource_GetNumberOfEdgesMinValue_21(HandleRef pThis);

		public virtual int GetNumberOfEdgesMinValue()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetNumberOfEdgesMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRandomGraphSource_GetNumberOfVertices_22(HandleRef pThis);

		public virtual int GetNumberOfVertices()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetNumberOfVertices_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRandomGraphSource_GetNumberOfVerticesMaxValue_23(HandleRef pThis);

		public virtual int GetNumberOfVerticesMaxValue()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetNumberOfVerticesMaxValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRandomGraphSource_GetNumberOfVerticesMinValue_24(HandleRef pThis);

		public virtual int GetNumberOfVerticesMinValue()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetNumberOfVerticesMinValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRandomGraphSource_GetSeed_25(HandleRef pThis);

		public virtual int GetSeed()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetSeed_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkRandomGraphSource_GetStartWithTree_26(HandleRef pThis);

		public virtual bool GetStartWithTree()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetStartWithTree_26(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkRandomGraphSource_GetUseEdgeProbability_27(HandleRef pThis);

		public virtual bool GetUseEdgeProbability()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetUseEdgeProbability_27(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRandomGraphSource_GetVertexPedigreeIdArrayName_28(HandleRef pThis);

		public virtual string GetVertexPedigreeIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRandomGraphSource.vtkRandomGraphSource_GetVertexPedigreeIdArrayName_28(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_IncludeEdgeWeightsOff_29(HandleRef pThis);

		public virtual void IncludeEdgeWeightsOff()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_IncludeEdgeWeightsOff_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_IncludeEdgeWeightsOn_30(HandleRef pThis);

		public virtual void IncludeEdgeWeightsOn()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_IncludeEdgeWeightsOn_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRandomGraphSource_IsA_31(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_IsA_31(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRandomGraphSource_IsTypeOf_32(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_IsTypeOf_32(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRandomGraphSource_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRandomGraphSource NewInstance()
		{
			vtkRandomGraphSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRandomGraphSource.vtkRandomGraphSource_NewInstance_34(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRandomGraphSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRandomGraphSource_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRandomGraphSource SafeDownCast(vtkObjectBase o)
		{
			vtkRandomGraphSource vtkRandomGraphSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRandomGraphSource.vtkRandomGraphSource_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRandomGraphSource = (vtkRandomGraphSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRandomGraphSource.Register(null);
				}
			}
			return vtkRandomGraphSource;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_SetAllowParallelEdges_36(HandleRef pThis, byte _arg);

		public virtual void SetAllowParallelEdges(bool _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetAllowParallelEdges_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_SetAllowSelfLoops_37(HandleRef pThis, byte _arg);

		public virtual void SetAllowSelfLoops(bool _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetAllowSelfLoops_37(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_SetDirected_38(HandleRef pThis, byte _arg);

		public virtual void SetDirected(bool _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetDirected_38(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_SetEdgePedigreeIdArrayName_39(HandleRef pThis, string _arg);

		public virtual void SetEdgePedigreeIdArrayName(string _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetEdgePedigreeIdArrayName_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_SetEdgeProbability_40(HandleRef pThis, double _arg);

		public virtual void SetEdgeProbability(double _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetEdgeProbability_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_SetEdgeWeightArrayName_41(HandleRef pThis, string _arg);

		public virtual void SetEdgeWeightArrayName(string _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetEdgeWeightArrayName_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_SetGeneratePedigreeIds_42(HandleRef pThis, byte _arg);

		public virtual void SetGeneratePedigreeIds(bool _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetGeneratePedigreeIds_42(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_SetIncludeEdgeWeights_43(HandleRef pThis, byte _arg);

		public virtual void SetIncludeEdgeWeights(bool _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetIncludeEdgeWeights_43(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_SetNumberOfEdges_44(HandleRef pThis, int _arg);

		public virtual void SetNumberOfEdges(int _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetNumberOfEdges_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_SetNumberOfVertices_45(HandleRef pThis, int _arg);

		public virtual void SetNumberOfVertices(int _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetNumberOfVertices_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_SetSeed_46(HandleRef pThis, int _arg);

		public virtual void SetSeed(int _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetSeed_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_SetStartWithTree_47(HandleRef pThis, byte _arg);

		public virtual void SetStartWithTree(bool _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetStartWithTree_47(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_SetUseEdgeProbability_48(HandleRef pThis, byte _arg);

		public virtual void SetUseEdgeProbability(bool _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetUseEdgeProbability_48(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_SetVertexPedigreeIdArrayName_49(HandleRef pThis, string _arg);

		public virtual void SetVertexPedigreeIdArrayName(string _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetVertexPedigreeIdArrayName_49(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_StartWithTreeOff_50(HandleRef pThis);

		public virtual void StartWithTreeOff()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_StartWithTreeOff_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_StartWithTreeOn_51(HandleRef pThis);

		public virtual void StartWithTreeOn()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_StartWithTreeOn_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_UseEdgeProbabilityOff_52(HandleRef pThis);

		public virtual void UseEdgeProbabilityOff()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_UseEdgeProbabilityOff_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomGraphSource_UseEdgeProbabilityOn_53(HandleRef pThis);

		public virtual void UseEdgeProbabilityOn()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_UseEdgeProbabilityOn_53(base.GetCppThis());
		}
	}
}
