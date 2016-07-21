using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtentSplitter : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtentSplitter";

		public new static readonly string MRClassNameKey;

		static vtkExtentSplitter()
		{
			vtkExtentSplitter.MRClassNameKey = "class vtkExtentSplitter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtentSplitter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtentSplitter"));
		}

		public vtkExtentSplitter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkExtentSplitter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtentSplitter New()
		{
			vtkExtentSplitter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtentSplitter.vtkExtentSplitter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtentSplitter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtentSplitter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtentSplitter.vtkExtentSplitter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentSplitter_AddExtent_01(HandleRef pThis, int x0, int x1, int y0, int y1, int z0, int z1);

		public void AddExtent(int x0, int x1, int y0, int y1, int z0, int z1)
		{
			vtkExtentSplitter.vtkExtentSplitter_AddExtent_01(base.GetCppThis(), x0, x1, y0, y1, z0, z1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentSplitter_AddExtent_02(HandleRef pThis, IntPtr extent);

		public void AddExtent(IntPtr extent)
		{
			vtkExtentSplitter.vtkExtentSplitter_AddExtent_02(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentSplitter_AddExtentSource_03(HandleRef pThis, int id, int priority, int x0, int x1, int y0, int y1, int z0, int z1);

		public void AddExtentSource(int id, int priority, int x0, int x1, int y0, int y1, int z0, int z1)
		{
			vtkExtentSplitter.vtkExtentSplitter_AddExtentSource_03(base.GetCppThis(), id, priority, x0, x1, y0, y1, z0, z1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentSplitter_AddExtentSource_04(HandleRef pThis, int id, int priority, IntPtr extent);

		public void AddExtentSource(int id, int priority, IntPtr extent)
		{
			vtkExtentSplitter.vtkExtentSplitter_AddExtentSource_04(base.GetCppThis(), id, priority, extent);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkExtentSplitter_ComputeSubExtents_05(HandleRef pThis);

		public int ComputeSubExtents()
		{
			return vtkExtentSplitter.vtkExtentSplitter_ComputeSubExtents_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkExtentSplitter_GetNumberOfSubExtents_06(HandleRef pThis);

		public int GetNumberOfSubExtents()
		{
			return vtkExtentSplitter.vtkExtentSplitter_GetNumberOfSubExtents_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkExtentSplitter_GetPointMode_07(HandleRef pThis);

		public virtual int GetPointMode()
		{
			return vtkExtentSplitter.vtkExtentSplitter_GetPointMode_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkExtentSplitter_GetSubExtent_08(HandleRef pThis, int index);

		public int[] GetSubExtent(int index)
		{
			IntPtr intPtr = vtkExtentSplitter.vtkExtentSplitter_GetSubExtent_08(base.GetCppThis(), index);
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentSplitter_GetSubExtent_09(HandleRef pThis, int index, IntPtr extent);

		public void GetSubExtent(int index, IntPtr extent)
		{
			vtkExtentSplitter.vtkExtentSplitter_GetSubExtent_09(base.GetCppThis(), index, extent);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkExtentSplitter_GetSubExtentSource_10(HandleRef pThis, int index);

		public int GetSubExtentSource(int index)
		{
			return vtkExtentSplitter.vtkExtentSplitter_GetSubExtentSource_10(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkExtentSplitter_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtentSplitter.vtkExtentSplitter_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkExtentSplitter_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtentSplitter.vtkExtentSplitter_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkExtentSplitter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtentSplitter NewInstance()
		{
			vtkExtentSplitter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtentSplitter.vtkExtentSplitter_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtentSplitter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentSplitter_PointModeOff_15(HandleRef pThis);

		public virtual void PointModeOff()
		{
			vtkExtentSplitter.vtkExtentSplitter_PointModeOff_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentSplitter_PointModeOn_16(HandleRef pThis);

		public virtual void PointModeOn()
		{
			vtkExtentSplitter.vtkExtentSplitter_PointModeOn_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentSplitter_RemoveAllExtentSources_17(HandleRef pThis);

		public void RemoveAllExtentSources()
		{
			vtkExtentSplitter.vtkExtentSplitter_RemoveAllExtentSources_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentSplitter_RemoveExtentSource_18(HandleRef pThis, int id);

		public void RemoveExtentSource(int id)
		{
			vtkExtentSplitter.vtkExtentSplitter_RemoveExtentSource_18(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkExtentSplitter_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtentSplitter SafeDownCast(vtkObjectBase o)
		{
			vtkExtentSplitter vtkExtentSplitter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtentSplitter.vtkExtentSplitter_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtentSplitter = (vtkExtentSplitter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtentSplitter.Register(null);
				}
			}
			return vtkExtentSplitter;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentSplitter_SetPointMode_20(HandleRef pThis, int _arg);

		public virtual void SetPointMode(int _arg)
		{
			vtkExtentSplitter.vtkExtentSplitter_SetPointMode_20(base.GetCppThis(), _arg);
		}
	}
}
