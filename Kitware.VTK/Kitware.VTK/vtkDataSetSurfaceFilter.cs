using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataSetSurfaceFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetSurfaceFilter";

		public new static readonly string MRClassNameKey;

		static vtkDataSetSurfaceFilter()
		{
			vtkDataSetSurfaceFilter.MRClassNameKey = "class vtkDataSetSurfaceFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetSurfaceFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetSurfaceFilter"));
		}

		public vtkDataSetSurfaceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetSurfaceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetSurfaceFilter New()
		{
			vtkDataSetSurfaceFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataSetSurfaceFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetSurfaceFilter_DataSetExecute_01(HandleRef pThis, HandleRef input, HandleRef output);

		public virtual int DataSetExecute(vtkDataSet input, vtkPolyData output)
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_DataSetExecute_01(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetSurfaceFilter_GetNonlinearSubdivisionLevel_02(HandleRef pThis);

		public virtual int GetNonlinearSubdivisionLevel()
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_GetNonlinearSubdivisionLevel_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetSurfaceFilter_GetOriginalCellIdsName_03(HandleRef pThis);

		public virtual string GetOriginalCellIdsName()
		{
			return Marshal.PtrToStringAnsi(vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_GetOriginalCellIdsName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetSurfaceFilter_GetOriginalPointIdsName_04(HandleRef pThis);

		public virtual string GetOriginalPointIdsName()
		{
			return Marshal.PtrToStringAnsi(vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_GetOriginalPointIdsName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetSurfaceFilter_GetPassThroughCellIds_05(HandleRef pThis);

		public virtual int GetPassThroughCellIds()
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_GetPassThroughCellIds_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetSurfaceFilter_GetPassThroughPointIds_06(HandleRef pThis);

		public virtual int GetPassThroughPointIds()
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_GetPassThroughPointIds_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetSurfaceFilter_GetPieceInvariant_07(HandleRef pThis);

		public virtual int GetPieceInvariant()
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_GetPieceInvariant_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetSurfaceFilter_GetUseStrips_08(HandleRef pThis);

		public virtual int GetUseStrips()
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_GetUseStrips_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetSurfaceFilter_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetSurfaceFilter_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetSurfaceFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataSetSurfaceFilter NewInstance()
		{
			vtkDataSetSurfaceFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetSurfaceFilter_PassThroughCellIdsOff_13(HandleRef pThis);

		public virtual void PassThroughCellIdsOff()
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_PassThroughCellIdsOff_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetSurfaceFilter_PassThroughCellIdsOn_14(HandleRef pThis);

		public virtual void PassThroughCellIdsOn()
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_PassThroughCellIdsOn_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetSurfaceFilter_PassThroughPointIdsOff_15(HandleRef pThis);

		public virtual void PassThroughPointIdsOff()
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_PassThroughPointIdsOff_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetSurfaceFilter_PassThroughPointIdsOn_16(HandleRef pThis);

		public virtual void PassThroughPointIdsOn()
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_PassThroughPointIdsOn_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetSurfaceFilter_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetSurfaceFilter SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetSurfaceFilter vtkDataSetSurfaceFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetSurfaceFilter = (vtkDataSetSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetSurfaceFilter.Register(null);
				}
			}
			return vtkDataSetSurfaceFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetSurfaceFilter_SetNonlinearSubdivisionLevel_18(HandleRef pThis, int _arg);

		public virtual void SetNonlinearSubdivisionLevel(int _arg)
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_SetNonlinearSubdivisionLevel_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetSurfaceFilter_SetOriginalCellIdsName_19(HandleRef pThis, string _arg);

		public virtual void SetOriginalCellIdsName(string _arg)
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_SetOriginalCellIdsName_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetSurfaceFilter_SetOriginalPointIdsName_20(HandleRef pThis, string _arg);

		public virtual void SetOriginalPointIdsName(string _arg)
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_SetOriginalPointIdsName_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetSurfaceFilter_SetPassThroughCellIds_21(HandleRef pThis, int _arg);

		public virtual void SetPassThroughCellIds(int _arg)
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_SetPassThroughCellIds_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetSurfaceFilter_SetPassThroughPointIds_22(HandleRef pThis, int _arg);

		public virtual void SetPassThroughPointIds(int _arg)
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_SetPassThroughPointIds_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetSurfaceFilter_SetPieceInvariant_23(HandleRef pThis, int _arg);

		public virtual void SetPieceInvariant(int _arg)
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_SetPieceInvariant_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetSurfaceFilter_SetUseStrips_24(HandleRef pThis, int _arg);

		public virtual void SetUseStrips(int _arg)
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_SetUseStrips_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetSurfaceFilter_StructuredExecute_25(HandleRef pThis, HandleRef input, HandleRef output, IntPtr ext, IntPtr wholeExt);

		public virtual int StructuredExecute(vtkDataSet input, vtkPolyData output, IntPtr ext, IntPtr wholeExt)
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_StructuredExecute_25(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis(), ext, wholeExt);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetSurfaceFilter_UnstructuredGridExecute_26(HandleRef pThis, HandleRef input, HandleRef output);

		public virtual int UnstructuredGridExecute(vtkDataSet input, vtkPolyData output)
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_UnstructuredGridExecute_26(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetSurfaceFilter_UseStripsOff_27(HandleRef pThis);

		public virtual void UseStripsOff()
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_UseStripsOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetSurfaceFilter_UseStripsOn_28(HandleRef pThis);

		public virtual void UseStripsOn()
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_UseStripsOn_28(base.GetCppThis());
		}
	}
}
