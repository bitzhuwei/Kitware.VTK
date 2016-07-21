using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoRandomGraphSource : vtkRandomGraphSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoRandomGraphSource";

		public new static readonly string MRClassNameKey;

		static vtkGeoRandomGraphSource()
		{
			vtkGeoRandomGraphSource.MRClassNameKey = "class vtkGeoRandomGraphSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoRandomGraphSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoRandomGraphSource"));
		}

		public vtkGeoRandomGraphSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoRandomGraphSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoRandomGraphSource New()
		{
			vtkGeoRandomGraphSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoRandomGraphSource.vtkGeoRandomGraphSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoRandomGraphSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoRandomGraphSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoRandomGraphSource.vtkGeoRandomGraphSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoRandomGraphSource_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoRandomGraphSource.vtkGeoRandomGraphSource_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoRandomGraphSource_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoRandomGraphSource.vtkGeoRandomGraphSource_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoRandomGraphSource_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoRandomGraphSource NewInstance()
		{
			vtkGeoRandomGraphSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoRandomGraphSource.vtkGeoRandomGraphSource_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoRandomGraphSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoRandomGraphSource_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoRandomGraphSource SafeDownCast(vtkObjectBase o)
		{
			vtkGeoRandomGraphSource vtkGeoRandomGraphSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoRandomGraphSource.vtkGeoRandomGraphSource_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoRandomGraphSource = (vtkGeoRandomGraphSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoRandomGraphSource.Register(null);
				}
			}
			return vtkGeoRandomGraphSource;
		}
	}
}
