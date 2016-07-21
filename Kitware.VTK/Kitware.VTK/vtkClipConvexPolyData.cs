using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkClipConvexPolyData : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkClipConvexPolyData";

		public new static readonly string MRClassNameKey;

		static vtkClipConvexPolyData()
		{
			vtkClipConvexPolyData.MRClassNameKey = "class vtkClipConvexPolyData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClipConvexPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClipConvexPolyData"));
		}

		public vtkClipConvexPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipConvexPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClipConvexPolyData New()
		{
			vtkClipConvexPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipConvexPolyData.vtkClipConvexPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipConvexPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkClipConvexPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkClipConvexPolyData.vtkClipConvexPolyData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkClipConvexPolyData_GetMTime_01(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkClipConvexPolyData.vtkClipConvexPolyData_GetMTime_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipConvexPolyData_GetPlanes_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPlaneCollection GetPlanes()
		{
			vtkPlaneCollection vtkPlaneCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipConvexPolyData.vtkClipConvexPolyData_GetPlanes_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaneCollection = (vtkPlaneCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaneCollection.Register(null);
				}
			}
			return vtkPlaneCollection;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipConvexPolyData_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkClipConvexPolyData.vtkClipConvexPolyData_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipConvexPolyData_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkClipConvexPolyData.vtkClipConvexPolyData_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipConvexPolyData_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkClipConvexPolyData NewInstance()
		{
			vtkClipConvexPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipConvexPolyData.vtkClipConvexPolyData_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipConvexPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipConvexPolyData_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClipConvexPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkClipConvexPolyData vtkClipConvexPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipConvexPolyData.vtkClipConvexPolyData_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClipConvexPolyData = (vtkClipConvexPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClipConvexPolyData.Register(null);
				}
			}
			return vtkClipConvexPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipConvexPolyData_SetPlanes_08(HandleRef pThis, HandleRef planes);

		public void SetPlanes(vtkPlaneCollection planes)
		{
			vtkClipConvexPolyData.vtkClipConvexPolyData_SetPlanes_08(base.GetCppThis(), (planes == null) ? default(HandleRef) : planes.GetCppThis());
		}
	}
}
