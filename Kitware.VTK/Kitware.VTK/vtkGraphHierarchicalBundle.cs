using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGraphHierarchicalBundle : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphHierarchicalBundle";

		public new static readonly string MRClassNameKey;

		static vtkGraphHierarchicalBundle()
		{
			vtkGraphHierarchicalBundle.MRClassNameKey = "class vtkGraphHierarchicalBundle";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphHierarchicalBundle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphHierarchicalBundle"));
		}

		public vtkGraphHierarchicalBundle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphHierarchicalBundle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphHierarchicalBundle New()
		{
			vtkGraphHierarchicalBundle result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphHierarchicalBundle.vtkGraphHierarchicalBundle_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphHierarchicalBundle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGraphHierarchicalBundle() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGraphHierarchicalBundle.vtkGraphHierarchicalBundle_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGraphHierarchicalBundle_DirectMappingOff_01(HandleRef pThis);

		public virtual void DirectMappingOff()
		{
			vtkGraphHierarchicalBundle.vtkGraphHierarchicalBundle_DirectMappingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGraphHierarchicalBundle_DirectMappingOn_02(HandleRef pThis);

		public virtual void DirectMappingOn()
		{
			vtkGraphHierarchicalBundle.vtkGraphHierarchicalBundle_DirectMappingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGraphHierarchicalBundle_FillInputPortInformation_03(HandleRef pThis, int port, HandleRef info);

		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkGraphHierarchicalBundle.vtkGraphHierarchicalBundle_FillInputPortInformation_03(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkGraphHierarchicalBundle_GetBundlingStrength_04(HandleRef pThis);

		public virtual double GetBundlingStrength()
		{
			return vtkGraphHierarchicalBundle.vtkGraphHierarchicalBundle_GetBundlingStrength_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkGraphHierarchicalBundle_GetBundlingStrengthMaxValue_05(HandleRef pThis);

		public virtual double GetBundlingStrengthMaxValue()
		{
			return vtkGraphHierarchicalBundle.vtkGraphHierarchicalBundle_GetBundlingStrengthMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkGraphHierarchicalBundle_GetBundlingStrengthMinValue_06(HandleRef pThis);

		public virtual double GetBundlingStrengthMinValue()
		{
			return vtkGraphHierarchicalBundle.vtkGraphHierarchicalBundle_GetBundlingStrengthMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkGraphHierarchicalBundle_GetDirectMapping_07(HandleRef pThis);

		public virtual bool GetDirectMapping()
		{
			return vtkGraphHierarchicalBundle.vtkGraphHierarchicalBundle_GetDirectMapping_07(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGraphHierarchicalBundle_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGraphHierarchicalBundle.vtkGraphHierarchicalBundle_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGraphHierarchicalBundle_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGraphHierarchicalBundle.vtkGraphHierarchicalBundle_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphHierarchicalBundle_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGraphHierarchicalBundle NewInstance()
		{
			vtkGraphHierarchicalBundle result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphHierarchicalBundle.vtkGraphHierarchicalBundle_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphHierarchicalBundle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphHierarchicalBundle_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphHierarchicalBundle SafeDownCast(vtkObjectBase o)
		{
			vtkGraphHierarchicalBundle vtkGraphHierarchicalBundle = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphHierarchicalBundle.vtkGraphHierarchicalBundle_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphHierarchicalBundle = (vtkGraphHierarchicalBundle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphHierarchicalBundle.Register(null);
				}
			}
			return vtkGraphHierarchicalBundle;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGraphHierarchicalBundle_SetBundlingStrength_13(HandleRef pThis, double _arg);

		public virtual void SetBundlingStrength(double _arg)
		{
			vtkGraphHierarchicalBundle.vtkGraphHierarchicalBundle_SetBundlingStrength_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGraphHierarchicalBundle_SetDirectMapping_14(HandleRef pThis, byte _arg);

		public virtual void SetDirectMapping(bool _arg)
		{
			vtkGraphHierarchicalBundle.vtkGraphHierarchicalBundle_SetDirectMapping_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}
