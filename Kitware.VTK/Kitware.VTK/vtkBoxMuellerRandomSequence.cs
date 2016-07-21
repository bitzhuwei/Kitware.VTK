using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBoxMuellerRandomSequence : vtkGaussianRandomSequence
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBoxMuellerRandomSequence";

		public new static readonly string MRClassNameKey;

		static vtkBoxMuellerRandomSequence()
		{
			vtkBoxMuellerRandomSequence.MRClassNameKey = "class vtkBoxMuellerRandomSequence";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBoxMuellerRandomSequence.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoxMuellerRandomSequence"));
		}

		public vtkBoxMuellerRandomSequence(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxMuellerRandomSequence_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBoxMuellerRandomSequence New()
		{
			vtkBoxMuellerRandomSequence result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxMuellerRandomSequence)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBoxMuellerRandomSequence() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxMuellerRandomSequence_GetUniformSequence_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkRandomSequence GetUniformSequence()
		{
			vtkRandomSequence vtkRandomSequence = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_GetUniformSequence_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRandomSequence = (vtkRandomSequence)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRandomSequence.Register(null);
				}
			}
			return vtkRandomSequence;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkBoxMuellerRandomSequence_GetValue_02(HandleRef pThis);

		public override double GetValue()
		{
			return vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_GetValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkBoxMuellerRandomSequence_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkBoxMuellerRandomSequence_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxMuellerRandomSequence_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBoxMuellerRandomSequence NewInstance()
		{
			vtkBoxMuellerRandomSequence result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxMuellerRandomSequence)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBoxMuellerRandomSequence_Next_07(HandleRef pThis);

		public override void Next()
		{
			vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_Next_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxMuellerRandomSequence_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBoxMuellerRandomSequence SafeDownCast(vtkObjectBase o)
		{
			vtkBoxMuellerRandomSequence vtkBoxMuellerRandomSequence = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBoxMuellerRandomSequence = (vtkBoxMuellerRandomSequence)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBoxMuellerRandomSequence.Register(null);
				}
			}
			return vtkBoxMuellerRandomSequence;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBoxMuellerRandomSequence_SetUniformSequence_09(HandleRef pThis, HandleRef uniformSequence);

		public void SetUniformSequence(vtkRandomSequence uniformSequence)
		{
			vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_SetUniformSequence_09(base.GetCppThis(), (uniformSequence == null) ? default(HandleRef) : uniformSequence.GetCppThis());
		}
	}
}
