using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractGrid : vtkStructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractGrid";

		public new static readonly string MRClassNameKey;

		static vtkExtractGrid()
		{
			vtkExtractGrid.MRClassNameKey = "class vtkExtractGrid";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractGrid"));
		}

		public vtkExtractGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractGrid New()
		{
			vtkExtractGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractGrid.vtkExtractGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractGrid.vtkExtractGrid_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractGrid_GetIncludeBoundary_01(HandleRef pThis);

		public virtual int GetIncludeBoundary()
		{
			return vtkExtractGrid.vtkExtractGrid_GetIncludeBoundary_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractGrid_GetSampleRate_02(HandleRef pThis);

		public virtual int[] GetSampleRate()
		{
			IntPtr intPtr = vtkExtractGrid.vtkExtractGrid_GetSampleRate_02(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractGrid_GetSampleRate_03(HandleRef pThis, IntPtr data);

		public virtual void GetSampleRate(IntPtr data)
		{
			vtkExtractGrid.vtkExtractGrid_GetSampleRate_03(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractGrid_GetVOI_04(HandleRef pThis);

		public virtual int[] GetVOI()
		{
			IntPtr intPtr = vtkExtractGrid.vtkExtractGrid_GetVOI_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractGrid_GetVOI_05(HandleRef pThis, IntPtr data);

		public virtual void GetVOI(IntPtr data)
		{
			vtkExtractGrid.vtkExtractGrid_GetVOI_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractGrid_IncludeBoundaryOff_06(HandleRef pThis);

		public virtual void IncludeBoundaryOff()
		{
			vtkExtractGrid.vtkExtractGrid_IncludeBoundaryOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractGrid_IncludeBoundaryOn_07(HandleRef pThis);

		public virtual void IncludeBoundaryOn()
		{
			vtkExtractGrid.vtkExtractGrid_IncludeBoundaryOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractGrid_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractGrid.vtkExtractGrid_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractGrid_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractGrid.vtkExtractGrid_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractGrid_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractGrid NewInstance()
		{
			vtkExtractGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractGrid.vtkExtractGrid_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractGrid_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractGrid SafeDownCast(vtkObjectBase o)
		{
			vtkExtractGrid vtkExtractGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractGrid.vtkExtractGrid_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractGrid = (vtkExtractGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractGrid.Register(null);
				}
			}
			return vtkExtractGrid;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractGrid_SetIncludeBoundary_13(HandleRef pThis, int _arg);

		public virtual void SetIncludeBoundary(int _arg)
		{
			vtkExtractGrid.vtkExtractGrid_SetIncludeBoundary_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractGrid_SetSampleRate_14(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		public virtual void SetSampleRate(int _arg1, int _arg2, int _arg3)
		{
			vtkExtractGrid.vtkExtractGrid_SetSampleRate_14(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractGrid_SetSampleRate_15(HandleRef pThis, IntPtr _arg);

		public virtual void SetSampleRate(IntPtr _arg)
		{
			vtkExtractGrid.vtkExtractGrid_SetSampleRate_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractGrid_SetVOI_16(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetVOI(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkExtractGrid.vtkExtractGrid_SetVOI_16(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractGrid_SetVOI_17(HandleRef pThis, IntPtr _arg);

		public virtual void SetVOI(IntPtr _arg)
		{
			vtkExtractGrid.vtkExtractGrid_SetVOI_17(base.GetCppThis(), _arg);
		}
	}
}
