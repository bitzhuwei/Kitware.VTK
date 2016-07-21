using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkGeodesicPath : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeodesicPath";

		public new static readonly string MRClassNameKey;

		static vtkGeodesicPath()
		{
			vtkGeodesicPath.MRClassNameKey = "class vtkGeodesicPath";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeodesicPath.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeodesicPath"));
		}

		public vtkGeodesicPath(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkGeodesicPath_GetGeodesicLength_01(HandleRef pThis);

		public virtual double GetGeodesicLength()
		{
			return vtkGeodesicPath.vtkGeodesicPath_GetGeodesicLength_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGeodesicPath_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeodesicPath.vtkGeodesicPath_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGeodesicPath_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeodesicPath.vtkGeodesicPath_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGeodesicPath_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeodesicPath NewInstance()
		{
			vtkGeodesicPath result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeodesicPath.vtkGeodesicPath_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeodesicPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGeodesicPath_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeodesicPath SafeDownCast(vtkObjectBase o)
		{
			vtkGeodesicPath vtkGeodesicPath = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeodesicPath.vtkGeodesicPath_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeodesicPath = (vtkGeodesicPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeodesicPath.Register(null);
				}
			}
			return vtkGeodesicPath;
		}
	}
}
