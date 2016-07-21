using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageAppendComponents : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageAppendComponents";

		public new static readonly string MRClassNameKey;

		static vtkImageAppendComponents()
		{
			vtkImageAppendComponents.MRClassNameKey = "class vtkImageAppendComponents";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageAppendComponents.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageAppendComponents"));
		}

		public vtkImageAppendComponents(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAppendComponents_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageAppendComponents New()
		{
			vtkImageAppendComponents result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAppendComponents.vtkImageAppendComponents_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAppendComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageAppendComponents() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageAppendComponents.vtkImageAppendComponents_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAppendComponents_GetInput_01(HandleRef pThis, int num, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataObject GetInput(int num)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAppendComponents.vtkImageAppendComponents_GetInput_01(base.GetCppThis(), num, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAppendComponents_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAppendComponents.vtkImageAppendComponents_GetInput_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAppendComponents_GetNumberOfInputs_03(HandleRef pThis);

		public int GetNumberOfInputs()
		{
			return vtkImageAppendComponents.vtkImageAppendComponents_GetNumberOfInputs_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAppendComponents_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageAppendComponents.vtkImageAppendComponents_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAppendComponents_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageAppendComponents.vtkImageAppendComponents_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAppendComponents_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageAppendComponents NewInstance()
		{
			vtkImageAppendComponents result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAppendComponents.vtkImageAppendComponents_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAppendComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAppendComponents_ReplaceNthInputConnection_08(HandleRef pThis, int idx, HandleRef input);

		public virtual void ReplaceNthInputConnection(int idx, vtkAlgorithmOutput input)
		{
			vtkImageAppendComponents.vtkImageAppendComponents_ReplaceNthInputConnection_08(base.GetCppThis(), idx, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAppendComponents_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageAppendComponents SafeDownCast(vtkObjectBase o)
		{
			vtkImageAppendComponents vtkImageAppendComponents = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAppendComponents.vtkImageAppendComponents_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageAppendComponents = (vtkImageAppendComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageAppendComponents.Register(null);
				}
			}
			return vtkImageAppendComponents;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAppendComponents_SetInput_10(HandleRef pThis, int num, HandleRef input);

		public new void SetInput(int num, vtkDataObject input)
		{
			vtkImageAppendComponents.vtkImageAppendComponents_SetInput_10(base.GetCppThis(), num, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAppendComponents_SetInput_11(HandleRef pThis, HandleRef input);

		public new void SetInput(vtkDataObject input)
		{
			vtkImageAppendComponents.vtkImageAppendComponents_SetInput_11(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}
