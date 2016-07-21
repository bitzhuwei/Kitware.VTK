using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorStyleTrackball : vtkInteractorStyleSwitch
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleTrackball";

		public new static readonly string MRClassNameKey;

		static vtkInteractorStyleTrackball()
		{
			vtkInteractorStyleTrackball.MRClassNameKey = "class vtkInteractorStyleTrackball";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleTrackball.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleTrackball"));
		}

		public vtkInteractorStyleTrackball(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleTrackball_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleTrackball New()
		{
			vtkInteractorStyleTrackball result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleTrackball.vtkInteractorStyleTrackball_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTrackball)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInteractorStyleTrackball() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInteractorStyleTrackball.vtkInteractorStyleTrackball_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleTrackball_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorStyleTrackball.vtkInteractorStyleTrackball_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleTrackball_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleTrackball.vtkInteractorStyleTrackball_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleTrackball_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorStyleTrackball NewInstance()
		{
			vtkInteractorStyleTrackball result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleTrackball.vtkInteractorStyleTrackball_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTrackball)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleTrackball_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleTrackball SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleTrackball vtkInteractorStyleTrackball = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleTrackball.vtkInteractorStyleTrackball_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleTrackball = (vtkInteractorStyleTrackball)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleTrackball.Register(null);
				}
			}
			return vtkInteractorStyleTrackball;
		}
	}
}
