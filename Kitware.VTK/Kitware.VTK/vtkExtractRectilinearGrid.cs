using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractRectilinearGrid : vtkRectilinearGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractRectilinearGrid";

		public new static readonly string MRClassNameKey;

		static vtkExtractRectilinearGrid()
		{
			vtkExtractRectilinearGrid.MRClassNameKey = "class vtkExtractRectilinearGrid";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractRectilinearGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractRectilinearGrid"));
		}

		public vtkExtractRectilinearGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractRectilinearGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractRectilinearGrid New()
		{
			vtkExtractRectilinearGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractRectilinearGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractRectilinearGrid_GetIncludeBoundary_01(HandleRef pThis);

		public virtual int GetIncludeBoundary()
		{
			return vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_GetIncludeBoundary_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractRectilinearGrid_GetSampleRate_02(HandleRef pThis);

		public virtual int[] GetSampleRate()
		{
			IntPtr intPtr = vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_GetSampleRate_02(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractRectilinearGrid_GetSampleRate_03(HandleRef pThis, IntPtr data);

		public virtual void GetSampleRate(IntPtr data)
		{
			vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_GetSampleRate_03(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractRectilinearGrid_GetVOI_04(HandleRef pThis);

		public virtual int[] GetVOI()
		{
			IntPtr intPtr = vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_GetVOI_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractRectilinearGrid_GetVOI_05(HandleRef pThis, IntPtr data);

		public virtual void GetVOI(IntPtr data)
		{
			vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_GetVOI_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractRectilinearGrid_IncludeBoundaryOff_06(HandleRef pThis);

		public virtual void IncludeBoundaryOff()
		{
			vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_IncludeBoundaryOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractRectilinearGrid_IncludeBoundaryOn_07(HandleRef pThis);

		public virtual void IncludeBoundaryOn()
		{
			vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_IncludeBoundaryOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractRectilinearGrid_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractRectilinearGrid_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractRectilinearGrid_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractRectilinearGrid NewInstance()
		{
			vtkExtractRectilinearGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractRectilinearGrid_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractRectilinearGrid SafeDownCast(vtkObjectBase o)
		{
			vtkExtractRectilinearGrid vtkExtractRectilinearGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractRectilinearGrid = (vtkExtractRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractRectilinearGrid.Register(null);
				}
			}
			return vtkExtractRectilinearGrid;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractRectilinearGrid_SetIncludeBoundary_13(HandleRef pThis, int _arg);

		public virtual void SetIncludeBoundary(int _arg)
		{
			vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_SetIncludeBoundary_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractRectilinearGrid_SetSampleRate_14(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		public virtual void SetSampleRate(int _arg1, int _arg2, int _arg3)
		{
			vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_SetSampleRate_14(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractRectilinearGrid_SetSampleRate_15(HandleRef pThis, IntPtr _arg);

		public virtual void SetSampleRate(IntPtr _arg)
		{
			vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_SetSampleRate_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractRectilinearGrid_SetVOI_16(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetVOI(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_SetVOI_16(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractRectilinearGrid_SetVOI_17(HandleRef pThis, IntPtr _arg);

		public virtual void SetVOI(IntPtr _arg)
		{
			vtkExtractRectilinearGrid.vtkExtractRectilinearGrid_SetVOI_17(base.GetCppThis(), _arg);
		}
	}
}
