using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkGraphGeodesicPath : vtkGeodesicPath
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphGeodesicPath";

		public new static readonly string MRClassNameKey;

		static vtkGraphGeodesicPath()
		{
			vtkGraphGeodesicPath.MRClassNameKey = "class vtkGraphGeodesicPath";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphGeodesicPath.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphGeodesicPath"));
		}

		public vtkGraphGeodesicPath(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkGraphGeodesicPath_GetEndVertex_01(HandleRef pThis);

		public virtual long GetEndVertex()
		{
			return vtkGraphGeodesicPath.vtkGraphGeodesicPath_GetEndVertex_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkGraphGeodesicPath_GetStartVertex_02(HandleRef pThis);

		public virtual long GetStartVertex()
		{
			return vtkGraphGeodesicPath.vtkGraphGeodesicPath_GetStartVertex_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGraphGeodesicPath_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGraphGeodesicPath.vtkGraphGeodesicPath_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGraphGeodesicPath_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGraphGeodesicPath.vtkGraphGeodesicPath_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphGeodesicPath_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGraphGeodesicPath NewInstance()
		{
			vtkGraphGeodesicPath result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphGeodesicPath.vtkGraphGeodesicPath_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphGeodesicPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphGeodesicPath_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphGeodesicPath SafeDownCast(vtkObjectBase o)
		{
			vtkGraphGeodesicPath vtkGraphGeodesicPath = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphGeodesicPath.vtkGraphGeodesicPath_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphGeodesicPath = (vtkGraphGeodesicPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphGeodesicPath.Register(null);
				}
			}
			return vtkGraphGeodesicPath;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGraphGeodesicPath_SetEndVertex_07(HandleRef pThis, long _arg);

		public virtual void SetEndVertex(long _arg)
		{
			vtkGraphGeodesicPath.vtkGraphGeodesicPath_SetEndVertex_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGraphGeodesicPath_SetStartVertex_08(HandleRef pThis, long _arg);

		public virtual void SetStartVertex(long _arg)
		{
			vtkGraphGeodesicPath.vtkGraphGeodesicPath_SetStartVertex_08(base.GetCppThis(), _arg);
		}
	}
}
