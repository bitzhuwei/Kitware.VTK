using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPOpenFOAMReader : vtkOpenFOAMReader
	{
		public enum caseType
		{
			DECOMPOSED_CASE,
			RECONSTRUCTED_CASE
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkPOpenFOAMReader";

		public new static readonly string MRClassNameKey;

		static vtkPOpenFOAMReader()
		{
			vtkPOpenFOAMReader.MRClassNameKey = "class vtkPOpenFOAMReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPOpenFOAMReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPOpenFOAMReader"));
		}

		public vtkPOpenFOAMReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPOpenFOAMReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPOpenFOAMReader New()
		{
			vtkPOpenFOAMReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPOpenFOAMReader.vtkPOpenFOAMReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPOpenFOAMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPOpenFOAMReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPOpenFOAMReader.vtkPOpenFOAMReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern vtkPOpenFOAMReader.caseType vtkPOpenFOAMReader_GetCaseType_01(HandleRef pThis);

		public virtual vtkPOpenFOAMReader.caseType GetCaseType()
		{
			return vtkPOpenFOAMReader.vtkPOpenFOAMReader_GetCaseType_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPOpenFOAMReader_GetController_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPOpenFOAMReader.vtkPOpenFOAMReader_GetController_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPOpenFOAMReader_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPOpenFOAMReader.vtkPOpenFOAMReader_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPOpenFOAMReader_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPOpenFOAMReader.vtkPOpenFOAMReader_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPOpenFOAMReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPOpenFOAMReader NewInstance()
		{
			vtkPOpenFOAMReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPOpenFOAMReader.vtkPOpenFOAMReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPOpenFOAMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPOpenFOAMReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPOpenFOAMReader SafeDownCast(vtkObjectBase o)
		{
			vtkPOpenFOAMReader vtkPOpenFOAMReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPOpenFOAMReader.vtkPOpenFOAMReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPOpenFOAMReader = (vtkPOpenFOAMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPOpenFOAMReader.Register(null);
				}
			}
			return vtkPOpenFOAMReader;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPOpenFOAMReader_SetCaseType_08(HandleRef pThis, int t);

		public void SetCaseType(int t)
		{
			vtkPOpenFOAMReader.vtkPOpenFOAMReader_SetCaseType_08(base.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPOpenFOAMReader_SetController_09(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPOpenFOAMReader.vtkPOpenFOAMReader_SetController_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
