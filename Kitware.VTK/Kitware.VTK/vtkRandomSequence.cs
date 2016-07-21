using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkRandomSequence : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRandomSequence";

		public new static readonly string MRClassNameKey;

		static vtkRandomSequence()
		{
			vtkRandomSequence.MRClassNameKey = "class vtkRandomSequence";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRandomSequence.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRandomSequence"));
		}

		public vtkRandomSequence(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkRandomSequence_GetValue_01(HandleRef pThis);

		public virtual double GetValue()
		{
			return vtkRandomSequence.vtkRandomSequence_GetValue_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkRandomSequence_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRandomSequence.vtkRandomSequence_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkRandomSequence_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRandomSequence.vtkRandomSequence_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkRandomSequence_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRandomSequence NewInstance()
		{
			vtkRandomSequence result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRandomSequence.vtkRandomSequence_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRandomSequence)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkRandomSequence_Next_05(HandleRef pThis);

		public virtual void Next()
		{
			vtkRandomSequence.vtkRandomSequence_Next_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkRandomSequence_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRandomSequence SafeDownCast(vtkObjectBase o)
		{
			vtkRandomSequence vtkRandomSequence = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRandomSequence.vtkRandomSequence_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	}
}
