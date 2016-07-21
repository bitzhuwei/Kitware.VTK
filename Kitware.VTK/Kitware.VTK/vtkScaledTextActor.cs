using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkScaledTextActor : vtkTextActor
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkScaledTextActor";

		public new static readonly string MRClassNameKey;

		static vtkScaledTextActor()
		{
			vtkScaledTextActor.MRClassNameKey = "class vtkScaledTextActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkScaledTextActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkScaledTextActor"));
		}

		public vtkScaledTextActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkScaledTextActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkScaledTextActor New()
		{
			vtkScaledTextActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScaledTextActor.vtkScaledTextActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScaledTextActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkScaledTextActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkScaledTextActor.vtkScaledTextActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScaledTextActor_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkScaledTextActor.vtkScaledTextActor_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScaledTextActor_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkScaledTextActor.vtkScaledTextActor_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkScaledTextActor_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkScaledTextActor NewInstance()
		{
			vtkScaledTextActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScaledTextActor.vtkScaledTextActor_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScaledTextActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkScaledTextActor_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkScaledTextActor SafeDownCast(vtkObjectBase o)
		{
			vtkScaledTextActor vtkScaledTextActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScaledTextActor.vtkScaledTextActor_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScaledTextActor = (vtkScaledTextActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScaledTextActor.Register(null);
				}
			}
			return vtkScaledTextActor;
		}
	}
}
